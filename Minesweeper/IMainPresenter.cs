namespace Minesweeper
{
    public interface IMainPresenter
    {

        void NewGame();
        void SaveGame();
        void LoadGame();
        void ShowSettings();        
        void RevealSquare(int row, int col);
        void FlagSquare(int row, int col);        
    }
}