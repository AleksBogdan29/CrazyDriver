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
        Random rand = new Random();
        Random carPosition = new Random();

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

            var controls = new Control[]
           {
                pictureBoxSpedometerIcon,
                labelTraining,
                pictureBoxRightKey,
                pictureBoxLeftKey,
                labelLeft,
                labelRight,
                pictureBoxCar,
                pictureBoxQuestionMark,
                label1,
                label2,
                label3,
                label4,
                pictureBoxQuestionMark2
                
           };

            foreach (var control in controls)
            {
                control.Parent = pictureBoxBackgroundTraining;
                control.BackColor = Color.Transparent;
            }


            pictureBoxQuestionMark2.Visible= false; 
            label1.Visible = false;
           label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void keisUp(object sender, KeyEventArgs e)
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

        private void keisDown(object sender, KeyEventArgs e)
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

        private void timerClick(object sender, EventArgs e)
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

        private void pictureBoxSpedometerIcon_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            labelLeft.Visible = false;
            labelRight.Visible = false;
            pictureBoxLeftKey.Visible = false;
            pictureBoxRightKey.Visible = false;
            pictureBoxCar.Visible = false;
            pictureBoxQuestionMark.Visible = false;
            pictureBoxQuestionMark2.Visible = true;
        }

        private void pictureBoxQuestionMark2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            labelLeft.Visible = true;
            labelRight.Visible = true;
            pictureBoxLeftKey.Visible = true;
            pictureBoxRightKey.Visible = true;
            pictureBoxCar.Visible = true;
            pictureBoxQuestionMark.Visible = true;
            pictureBoxQuestionMark2.Visible = false;
        }

        private void ResetGame()
        {
            timer1.Start();
        }
      
    }
}
