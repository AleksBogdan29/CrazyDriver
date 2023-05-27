using CrazyDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MovePlayer_GoesLeft_PlayerMovesLeft()
        {
            // Arrange
            var game = new FormGame(); // создаем экземпляр класса Game, в котором находится метод MovePlayer()
            game.goLeft = true; // устанавливаем флаг goLeft в true
            game.player.Left = 50; // устанавливаем начальную позицию игрока

            // Act
            game.MovePlayer(); // вызываем метод MovePlayer()

            // Assert
            Assert.AreEqual(40, game.player.Left); // проверяем, что игрок переместился на 10 пикселей влево
        }

        [TestMethod]
        public void MovePlayer_GoesRight_PlayerMovesRight()
        {
            // Arrange
            var game = new FormGame(); // создаем экземпляр класса Game, в котором находится метод MovePlayer()
            game.goRight = true; // устанавливаем флаг goRight в true
            game.player.Left = 50; // устанавливаем начальную позицию игрока

            // Act
            game.MovePlayer(); // вызываем метод MovePlayer()

            // Assert
            Assert.AreEqual(60, game.player.Left); // проверяем, что игрок переместился на 10 пикселей вправо
        }

        [TestMethod]
        public void MovePlayer_GoesLeftAndAtLeftBoundary_PlayerDoesNotMove()
        {
            // Arrange
            var game = new FormGame(); // создаем экземпляр класса Game, в котором находится метод MovePlayer()
            game.goLeft = true; // устанавливаем флаг goLeft в true
            game.player.Left = 10; // устанавливаем начальную позицию игрока на левой границе

            // Act
            game.MovePlayer(); // вызываем метод MovePlayer()

            // Assert
            Assert.AreEqual(10, game.player.Left); // проверяем, что игрок не переместился
        }

        [TestMethod]
        public void MovePlayer_GoesRightAndAtRightBoundary_PlayerDoesNotMove()
        {
            // Arrange
            var game = new FormGame(); // создаем экземпляр класса Game, в котором находится метод MovePlayer()
            game.goRight = true; // устанавливаем флаг goRight в true
            game.player.Left = 490; // устанавливаем начальную позицию игрока на правой границе

            // Act
            game.MovePlayer(); // вызываем метод MovePlayer()

            // Assert
            Assert.AreEqual(490, game.player.Left); // проверяем, что игрок не переместился
        }

        [TestMethod]
        public void UpdateScore_ScoreIncreasesByOne_LabelShowsNewScore()
        {
            // Arrange
            var formGame = new FormGame();
            var labelScore = formGame.Controls.Find("labelScore", true)[0] as Label;
            int initialScore = 0;

            // Act
            for (int i = 0; i < 9; i++)
            {
                formGame.UpdateScore();
            }

            // Assert
            Assert.AreEqual(initialScore + 9, formGame.score);
            Assert.AreEqual("Счет: " + (initialScore + 9), labelScore.Text);
        }

        [TestMethod]
        public void CheckCollision_PlayerIntersectsAI1_GameOver()
        {
            // Arrange
            var formGame = new FormGame();
            var player = formGame.Controls.Find("player", true)[0] as PictureBox;
            var ai1 = formGame.Controls.Find("AI1", true)[0] as PictureBox;
            var ai2 = formGame.Controls.Find("AI2", true)[0] as PictureBox;

            player.Left = ai1.Left;
            player.Top = ai1.Top;

            // Act
            formGame.CheckCollision();

            // Assert
            Assert.IsTrue(formGame.gameOver);
        }

        [TestMethod]
        public void CheckCollision_PlayerIntersectsAI2_GameOver()
        {
            // Arrange
            var formGame = new FormGame();
            var player = formGame.Controls.Find("player", true)[0] as PictureBox;
            var ai1 = formGame.Controls.Find("AI1", true)[0] as PictureBox;
            var ai2 = formGame.Controls.Find("AI2", true)[0] as PictureBox;

           
            player.Left = ai2.Left;
            player.Top = ai2.Top;

            // Act
            formGame.CheckCollision();

            // Assert
            Assert.IsTrue(formGame.gameOver);
        }

        [TestMethod]
        public void CheckCollision_PlayerDoesNotIntersectAI_NoGameOver()
        {
            // Arrange
            var formGame = new FormGame();
            var player = formGame.Controls.Find("player", true)[0] as PictureBox;
            var ai1 = formGame.Controls.Find("AI1", true)[0] as PictureBox;
            var ai2 = formGame.Controls.Find("AI2", true)[0] as PictureBox;

            player.Left = ai1.Left + ai1.Width + 10;
            player.Top = ai1.Top + ai1.Height + 10;

            // Act
            formGame.CheckCollision();

            // Assert
            Assert.IsFalse(formGame.gameOver);
        }

        [TestMethod]
        public void KeyisDown_LeftArrowPressed_GoLeftIsTrue()
        {
            // Arrange
            var formGame = new FormGame();
            var keyEventArgs = new KeyEventArgs(Keys.Left);

            // Act
            formGame.KeyisDown(this, keyEventArgs);

            // Assert
            Assert.IsTrue(formGame.goLeft);
        }

        [TestMethod]
        public void KeyisUp_LeftArrowReleased_GoLeftIsFalse()
        {
            // Arrange
            var formGame = new FormGame();
            var keyEventArgs = new KeyEventArgs(Keys.Left);

            // Act
            formGame.KeyisUp(this, keyEventArgs);

            // Assert
            Assert.IsFalse(formGame.goLeft);
        }

        [TestMethod]
        public void KeyisUp_RightArrowReleased_GoRightIsFalse()
        {
            // Arrange
            var formGame = new FormGame();
            var keyEventArgs = new KeyEventArgs(Keys.Right);

            // Act
            formGame.KeyisUp(this, keyEventArgs);

            // Assert
            Assert.IsFalse(formGame.goRight);
        }
        
       


    }
}

