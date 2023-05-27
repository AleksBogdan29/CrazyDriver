using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class FormTraining : Form
    {
        int playerSpeed = 12;
        bool goLeft, goRight;

        public FormTraining()
        {
            InitializeComponent();
            ResetGame();
        }

        private void FormTraining_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var controlsForBackgroundFormTraining = new Control[]
           {
                pictureBoxIconMenu,
                labelTraining,
                pictureBoxRightKey,
                pictureBoxLeftKey,
                labelLeft,
                labelRight,
                pictureBoxCar,
                pictureBoxQuestionMark,
                labelTextFirst,
                labelTextSecond,
                labelTextThird,
                labelTextFourth,
                pictureBoxQuestionMarkIcon

           };

            foreach (var control in controlsForBackgroundFormTraining)
            {
                control.Parent = pictureBoxBackgroundTraining;
                control.BackColor = Color.Transparent;
            }

            var controlsToHide = new Control[]
                {
                    pictureBoxQuestionMarkIcon,
                    labelTextFirst,
                    labelTextSecond,
                    labelTextThird,
                    labelTextFourth
                 };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }

        }

        private void ResetGame()
        {
            timerTraining.Start();
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void TimerTraining_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && pictureBoxCar.Left > 10)
            {
                pictureBoxCar.Left -= playerSpeed;
            }
            if (goRight == true && pictureBoxCar.Left < 490)
            {
                pictureBoxCar.Left += playerSpeed;
            }
        }

        private void PictureBoxIconMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void PictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            var controlsToHide = new Control[]
                {
                    labelLeft,
                    labelRight,
                    pictureBoxLeftKey,
                    pictureBoxRightKey,
                    pictureBoxCar,
                    pictureBoxQuestionMark
                 };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }

            var controlsToShow = new Control[]
               {
                    labelTextFirst,
                    labelTextSecond,
                    labelTextThird,
                    labelTextFourth,
                    pictureBoxQuestionMarkIcon
                };

            foreach (var control in controlsToShow)
            {
                control.Visible = true;
            }
        }

        private void PictureBoxQuestionMark2_Click(object sender, EventArgs e)
        {
            var controlsToShow = new Control[]
               {
                    labelLeft,
                    labelRight,
                    pictureBoxLeftKey,
                    pictureBoxRightKey,
                    pictureBoxCar,
                    pictureBoxQuestionMark
                };

            foreach (var control in controlsToShow)
            {
                control.Visible = true;
            }

            var controlsToHide = new Control[]
               {
                    labelTextFirst,
                    labelTextSecond,
                    labelTextThird,
                    labelTextFourth,
                    pictureBoxQuestionMarkIcon
                };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }

        }

    }
}
