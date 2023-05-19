using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class FormGame : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goLeft, goRight;

        public FormGame()
        {
            InitializeComponent();
            ResetGame();

        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        
            buttonStart.Visible = false;
            pictureBoxCrashCar.Visible = false;

            pictureBoxIconMenu.Visible = false;
            pictureBoxIconShop.Visible = false;

            panelForShop.Visible = false;

            var controls = new Control[]
      {
                labelChooseCar,
                labelNissan,
                pictureBoxNissan,
                labelChevrolet,
                pictureBoxChevrolet,
                pictureBoxKoenigsegg,
                labelKoenigsegg,
                pictureBoxLamborghini,
                labelLamborghini,
                labelCrazy,
                labelDriver,
                pictureBoxSpeedometer
                
      };

            foreach (var control in controls)
            {
                control.Parent = pictureBoxBackgroundShop;
                control.BackColor = Color.Transparent;
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

        private void GameTimerEvent(object sender, EventArgs e)
        {
            labelScore.Text = "Счет: " + score;
            score++;


            if (goLeft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 490)
            {
                player.Left += playerSpeed;
            }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 490)
            {
                roadTrack2.Top = -490;
            }
            if (roadTrack1.Top > 490)
            {
                roadTrack1.Top = -490;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;


            if (AI1.Top > 530)
            {
                ChangeAiCars(AI1);
            }

            if (AI2.Top > 530)
            {
                ChangeAiCars(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                GameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }


        }

        private void ChangeAiCars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 12);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulanceForTrafic_;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.audiForTrafic;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.lamborghiniForTrafic;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.lexusForTrafic;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.mercedesForTrafic_;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.nissanGTRForTrafic;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.peugeotForTrafic;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.policeCarForTrafic;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.porcheForTrafic;
                    break;
                case 10:
                    tempCar.Image = Properties.Resources.taxiCarForTrafic;
                    break;
                case 11:
                    tempCar.Image = Properties.Resources.volkswagenForTrafic;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }

        }

        private void GameOver()
        {
            PlaySoundCrash();
            gameTimer.Stop();

            buttonStart.Visible = true;
            pictureBoxCrashCar.Visible = true;
            pictureBoxCrashCar.BackColor = Color.Transparent;
            AI1.Visible = false;
            AI2.Visible = false;
            player.Visible = false;

            pictureBoxIconMenu.Visible = true;
            pictureBoxIconShop.Visible = true;

            award.Visible = true;
            award.BringToFront();

            buttonStart.Enabled = true;


        }

        private void ResetGame()
        {
            buttonStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.bronze;
            buttonStart.Visible = false;
            pictureBoxCrashCar.Visible = false;

            AI1.Visible = true;
            AI2.Visible = true;
            player.Visible = true;

            pictureBoxIconMenu.Visible = false;
            pictureBoxIconShop.Visible = false;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();

        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pictureBoxSpedometerIcon_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void pictureBoxIconShop_Click(object sender, EventArgs e)
        {
            panelForShop.Visible = true;
            award.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelForShop.Visible=false;
            award.Visible = true;
        }

        private void pictureBoxChevrolet_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.camaroPlayer;
            MessageBox.Show("Автомобиль выбран.");
        }

        private void pictureBoxNissan_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.nissanGTRForTrafic;
            MessageBox.Show("Автомобиль выбран.");
        }

        private void pictureBoxKoenigsegg_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.koenigeseggForPlayer;
            MessageBox.Show("Автомобиль выбран.");
        }

        private void pictureBoxLamborghini_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.lamborghiniForTrafic;
            MessageBox.Show("Автомобиль выбран.");
        }

        private void PlaySoundCrash()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream stream = assembly.GetManifestResourceStream(@"CrazyDriver.soundCrash.wav");
            SoundPlayer soundPlayer = new SoundPlayer(stream);
            soundPlayer.Play();

        }

    }
}
