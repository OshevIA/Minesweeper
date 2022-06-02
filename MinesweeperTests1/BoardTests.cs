using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper;
using Minesweeper.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Minesweeper.Tests
{
    [TestClass()]
    public class BoardTests
    {

        public struct Square
        {
            public bool IsMine { get; set; }
            public bool IsRevealed { get; set; }
            public bool IsFlagged { get; set; }
            public int AdjacentMines { get; set; }
        }



        [TestMethod()]
        public void SaveStateTest()
        {
            Board board = new Board(10, 10);

            Assert.IsNotNull(Board.SaveState(board));

        }

        [TestMethod()]
        public void LoadStateTest()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream(@"test.saper", FileMode.Open))
            {
                var gameState = (GameState)formatter.Deserialize(stream);
                Assert.IsNotNull(Board.LoadState(gameState));

            }
        }

        public void NullLoad()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream(" ", FileMode.Open))
            {
                var gameState = (GameState)formatter.Deserialize(stream);

            }
        }

        [TestMethod()]
        public void NullLoadTest()
        {
            Assert.ThrowsException<ArgumentException>(() => NullLoad());
        }
        public void Initialize(Square[,] square)
        {
            Random random = new Random();
            Square[,] board = square;
            int minesCount = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (random.Next(100) < 40)
                    {
                        board[i, j].IsMine = true;
                        minesCount++;
                    }
                }
            }            
        }

        [TestMethod()]
        public void InitializeTest()
        {
            Square[,] square = new Square[10, 10];
            Square[,] square1 = new Square[10, 10];
            Initialize(square);

            Assert.AreNotEqual(square1[0,1].IsMine, square[0,1].IsMine);            
        }
    }
}