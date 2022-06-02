using Minesweeper.Properties;
using Minesweeper.Serialization;
using System.Windows.Forms;

namespace Minesweeper
{
    public class MainPresenter : IMainPresenter
    {
        private const string DialogFileFilter = "saper files(*.saper)|*.saper|All files (*.*)|*.*";

        private readonly IMainView mainView;
        private readonly IGameSerializer serializer;
        private Board board;

        public MainPresenter(IMainView mainView, IGameSerializer serializer)
        {
            this.mainView = mainView;
            this.serializer = serializer;            
        }

        public void SaveGame()
        {
            using (FileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = DialogFileFilter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    serializer.Serialize(board, dialog.FileName);
                }
            }
        }

        public void LoadGame()
        {
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = DialogFileFilter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    board = serializer.Deserialize(dialog.FileName);
                    mainView.Rows = board.Rows;
                    mainView.Columns = board.Columns;
                    mainView.ShowBoard();
                    AddBoardEvents();
                    board.RecreateBoard();
                }
            }
        }

        public void NewGame()
        {
            mainView.Rows = Settings.Default.Rows;
            mainView.Columns = Settings.Default.Columns;
            mainView.ShowBoard();
            board = new Board(Settings.Default.Rows, Settings.Default.Columns);
            AddBoardEvents();
            board.Initialize();
        }


        public void ShowSettings()
        {
            using (var settings = new SettingsForm())
            {
                settings.ShowDialog();
            }
        }  

        public void RevealSquare(int row, int col)
        {
            board.RevealSquare(row, col);
        }

        public void FlagSquare(int row, int col)
        {
            board.FlagSquare(row, col);
        }

        private void AddBoardEvents()
        {
            board.SafeSquareRevealed += OnSafeSquareRevealed;
            board.MineRevealed += OnMineRevealed;
            board.SquareFlagged += OnSquareFlagged;
            board.SquareUnflagged += OnSquareUnflagged;
            board.GameLost += OnGameLost;
            board.GameWon += OnGameWon;
        }

        private void OnGameWon(object sender, GameWonEventArgs e)
        {
            MessageBox.Show("Поздавляю - вы победили!", "Победа", MessageBoxButtons.OK);
        }

        private void OnGameLost(object sender, System.EventArgs e)
        {
            MessageBox.Show("К сожалению - вы проиграли!", "Конец игры", MessageBoxButtons.OK);
        }

        private void OnSquareUnflagged(object sender, SquareEventArgs e)
        {
            mainView.ShowUnrevealed(e.Row, e.Column);
        }

        private void OnSquareFlagged(object sender, SquareEventArgs e)
        {
            mainView.ShowFlag(e.Row, e.Column);
        }

        private void OnMineRevealed(object sender, SquareEventArgs e)
        {
            mainView.ShowMine(e.Row, e.Column);
        }

        private void OnSafeSquareRevealed(object sender, SquareEventArgs e)
        {
            mainView.ShowRevealed(e.Row, e.Column, e.AdjacentMines);
        }
    }
}