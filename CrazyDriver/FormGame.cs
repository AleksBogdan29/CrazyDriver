using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class FormGame : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        public int score;
        int carImage;
        int bonusImage;
        Random rand = new Random();
        Random carPosition = new Random();
        Random bonusPosition = new Random();
        int money=0;

        public bool goLeft, goRight;
        public bool gameOver;

        public bool IsFastCar { get; set; }

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

            var controlsToHide = new Control[]
                {
                    buttonStart,
                    pictureBoxCrashCar,
                    pictureBoxIconMenu,
                    pictureBoxIconShop,
                    panelForShop,
                    panelChoiseRoad
                };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }

            var controlsForBackgroundPaneForlShop = new Control[]
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
                pictureBoxSpeedometer,
                pictureBoxOpenPanelChoiseRoad,
                pictureBoxIconDollarForNissan,
                labelPriceForNissan,
                pictureBoxIconDollarForChevrolet,
                labelPriceForChevrolet,
                pictureBoxIconDollarForKoenigsegg,
                labelPriceForKoenigsegg,
                pictureBoxIconDollarForLamborghini,
                labelPriceForLamborghini,
                
            };

            foreach (var control in controlsForBackgroundPaneForlShop)
            {
                control.Parent = pictureBoxBackgroundShop;
                control.BackColor = Color.Transparent;
            }

            var controlsForPnaekChoiseRoad = new Control[]
            {
              pictureBox2,
              labelChoiseLoacation,
              labelBadRoad,
              labelHigwayRoad
            };

            foreach (var control in controlsForPnaekChoiseRoad)
            {
                control.Parent = pictureBoxBackgroundPanelChoiseRoad;
                control.BackColor = Color.Transparent;
            }
        }

        public void KeyisDown(object sender, KeyEventArgs e)
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

        public void KeyisUp(object sender, KeyEventArgs e)
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

        public void UpdateScore()
        {
            labelScore.Text = "Счет: " + score;
            score++;
        }

        public void MovePlayer()
        {
            const int leftBoundary = 10;
            const int rightBoundary = 490;

            if (goLeft && player.Left > leftBoundary)
            {
                player.Left -= playerSpeed;
            }

            if (goRight && player.Left < rightBoundary)
            {
                player.Left += playerSpeed;
            }
        }

        public void CheckCollision()
        {
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                GameOver();
            }
        }

        public void CheckBonus()
        {

            if (player.Bounds.IntersectsWith(AI3.Bounds))
            {
                GetFastCar();
            }

            if (player.Bounds.IntersectsWith(AI4.Bounds))
            {
                ZeroOut();
            }

            if (player.Bounds.IntersectsWith(AI5.Bounds))
            {
                GetSlowCar();
            }

            if (player.Bounds.IntersectsWith(AI6.Bounds))
            {
               PlastScore();
            }

            if (player.Bounds.IntersectsWith(AI7.Bounds))
            {
                GetDollar();
            }
        }
        public void UpdateAward()
        {
            const int maxScoreForBronze = 40;
            const int maxScoreForSilver = 1000;
            const int maxScoreForGold = 3000;

            if (score > maxScoreForBronze && score < maxScoreForSilver)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > maxScoreForSilver && score < maxScoreForGold)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > maxScoreForGold)
            {
                award.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }

        private void MoveCars()
        {
            const int roadTrackHeight = 495;
            const int aiCarSpeed = 15;

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > roadTrackHeight)
            {
                roadTrack2.Top = -roadTrackHeight;
            }

            if (roadTrack1.Top > roadTrackHeight)
            {
                roadTrack1.Top = -roadTrackHeight;
            }

            MoveCar(AI1, aiCarSpeed);
            MoveCar(AI2, aiCarSpeed);
            MoveCar(AI3, aiCarSpeed);
            MoveCar(AI4, aiCarSpeed);
            MoveCar(AI5, aiCarSpeed);
            MoveCar(AI6, aiCarSpeed);
            MoveCar(AI7, aiCarSpeed);

            if (AI1.Top > 530)
            {
                ChangeAiCars(AI1);
            }

            if (AI2.Top > 530)
            {
                ChangeAiCars(AI2);
            }

            if (AI3.Top > 530)
            {
                ChangeFastCarBonus(AI3);
            }

            if (AI4.Top > 530)
            {
                ChangeAccountZeroing(AI4);
            }

            if (AI5.Top > 530)
            {
                ChangeSlowCarBonus(AI5);
            }

            if (AI6.Top > 530)
            {
                ChangePlastScore(AI6);
            }

            if (AI7.Top > 530)
            {
                ChangeDollar(AI7);
            }

            void MoveCar(PictureBox car, int speed)
            {
                car.Top += speed;
            }
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            UpdateScore();
            MovePlayer();
            CheckCollision();
            CheckBonus();
            UpdateAward();
            MoveCars();
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

        private async void ChangeFastCarBonus(PictureBox tempBonus)
        {
            await Task.Delay(5000);

            bonusImage = rand.Next(1, 2);

            switch (bonusImage)
            {

                case 1:
                    tempBonus.Image = Properties.Resources.zipIcon1;
                    break;
            }

            tempBonus.Top = bonusPosition.Next(100, 400) * -1;


            if ((string)tempBonus.Tag == "bonusFastCar")
            {
                tempBonus.Left = bonusPosition.Next(5, 422);
            }

        }

        private async void ChangeAccountZeroing(PictureBox tempBonus)
        {
            await Task.Delay(7000);

            bonusImage = rand.Next(1, 2);

            switch (bonusImage)
            {

                case 1:
                    tempBonus.Image = Properties.Resources.questionMark;
                    break;

            }

            tempBonus.Top = bonusPosition.Next(100, 400) * -1;

            if ((string)tempBonus.Tag == "bonusZeroScore")
            {
                tempBonus.Left = bonusPosition.Next(5, 422);
            }

        }

        private async void ChangeSlowCarBonus(PictureBox tempBonus)
        {
            await Task.Delay(8000);

            bonusImage = rand.Next(1, 2);

            switch (bonusImage)
            {

                case 1:
                    tempBonus.Image = Properties.Resources.snailIcon1;
                    break;

            }

            tempBonus.Top = bonusPosition.Next(100, 400) * -1;

            if ((string)tempBonus.Tag == "bonusSlowCar")
            {
                tempBonus.Left = bonusPosition.Next(5, 422);
            }

        }

        private async void ChangePlastScore(PictureBox tempBonus)
        {
            await Task.Delay(9000);

            bonusImage = rand.Next(1, 2);

            switch (bonusImage)
            {

                case 1:
                    tempBonus.Image = Properties.Resources.iconPlus;
                    break;

            }

            tempBonus.Top = bonusPosition.Next(100, 400) * -1;

            if ((string)tempBonus.Tag == "bonusPlastScore")
            {
                tempBonus.Left = bonusPosition.Next(5, 422);
            }

        }

        private async void ChangeDollar(PictureBox tempBonus)
        {
            await Task.Delay(2000);

            bonusImage = rand.Next(1, 2);

            switch (bonusImage)
            {

                case 1:
                    tempBonus.Image = Properties.Resources.iconDollar;
                    break;

            }

            tempBonus.Top = bonusPosition.Next(100, 400) * -1;

            if ((string)tempBonus.Tag == "bonusGetDollar")
            {
                tempBonus.Left = bonusPosition.Next(5, 422);
            }

        }



        public void GameOver()
        {
            PlaySoundCrash();
            gameTimer.Stop();
            pictureBoxCrashCar.BackColor = Color.Transparent;
            award.BringToFront();
            buttonStart.Enabled = true;

            var controlsToShow = new Control[]
               {
                   buttonStart,
                   pictureBoxCrashCar,
                   pictureBoxIconMenu,
                   pictureBoxIconShop,
                   award
                };

            foreach (var control in controlsToShow)
            {
                control.Visible = true;
            }

            var controlsToHide = new Control[]
              {
                  AI1,
                  AI2,
                  AI3,
                  AI4,
                  AI5,
                  AI6,
                  AI7,
                  player
               };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }
        }

        private void ResetGame()
        {
            buttonStart.Enabled = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.bronze;
            roadSpeed = 12;
            trafficSpeed = 15;
            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);
            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);
            gameTimer.Start();


            var controlsToShow = new Control[]
               {
                   AI1,
                  AI2,
                  AI3,
                  AI4,
                  AI5,
                  AI6,
                  AI7,
                  player
                };

            foreach (var control in controlsToShow)
            {
                control.Visible = true;
            }

            var controlsToHide = new Control[]
              {
                  buttonStart,
                   pictureBoxCrashCar,
                   pictureBoxIconMenu,
                   pictureBoxIconShop,
                   award,
                   explosion
               };

            foreach (var control in controlsToHide)
            {
                control.Visible = false;
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void PictureBoxIconMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void PictureBoxIconShop_Click(object sender, EventArgs e)
        {
            panelForShop.Visible = true;
            award.Visible = false;

        }

        private void pictureBoxIconCrossPanelShop_Click(object sender, EventArgs e)
        {
            panelForShop.Visible = false;
            award.Visible = true;
        }

        private void PictureBoxChevrolet_Click(object sender, EventArgs e)
        {
                player.Image = Properties.Resources.camaroPlayer;
                MessageBox.Show("Автомобиль выбран.");
        }

        private void PictureBoxNissan_Click(object sender, EventArgs e)
        {
            if (money >=5000)
            {
                player.Image = Properties.Resources.nissanGTRForTrafic;
                MessageBox.Show("Автомобиль выбран.");
            }

            else
            {

                MessageBox.Show("Недостаточно средств, приходите позже.");
            }
            
        }

        private void PictureBoxKoenigsegg_Click(object sender, EventArgs e)
        {
            if (money >= 20000)
            {
                player.Image = Properties.Resources.koenigeseggForPlayer;
                MessageBox.Show("Автомобиль выбран.");
            }
            else
            {
                MessageBox.Show("Недостаточно средств, приходите позже.");
            }
        }

        private void PictureBoxLamborghini_Click(object sender, EventArgs e)
        {
            if (money >= 15000)
            {
                player.Image = Properties.Resources.lamborghiniForTrafic;
                MessageBox.Show("Автомобиль выбран.");
            }
            else
            {
                MessageBox.Show("Недостаточно средств, приходите позже.");
            }
        }

        private async void GetFastCar()
        {
            player.Image = Properties.Resources.ferrariForDifferentCar;
            roadSpeed = 18;
            trafficSpeed = 20;
            await Task.Delay(3000);
            player.Image = Properties.Resources.camaroPlayer;
            roadSpeed = 12;
            trafficSpeed = 14;
        }

        private async void GetSlowCar()
        {
            player.Image = Properties.Resources.oldCar;
            roadSpeed = 6;
            trafficSpeed = 8;
            await Task.Delay(3000);
            player.Image = Properties.Resources.camaroPlayer;
            roadSpeed = 12;
            trafficSpeed = 14;

        }

        private void ZeroOut()
        {
            score = 0;
        }
        private void PlastScore()
        {
            score = score + 20;
        }

        private void GetDollar()
        {
          
            labelDollar.Text = "$" + money;
            money += 100; 

        }
        private void PictureBoxOpenPanelChoiseRoad_Click(object sender, EventArgs e)
        {
            panelChoiseRoad.Visible = true;
        }

        private void pictureBoxClosePanelChosieRoad_Click(object sender, EventArgs e)
        {
            panelChoiseRoad.Visible = false;
        }

        private void PictureBoxBadRoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Локация выбрана");
            roadTrack1.Image = Properties.Resources.badRoad;
            roadTrack2.Image = Properties.Resources.badRoad;

            var controlsForBadRoad = new Control[]
                {
                player,
                AI1,
                AI2,
                AI3,
                AI4,
                AI5,
                AI6,
                AI7,
                pictureBoxIconMenu,
                pictureBoxIconShop,
                pictureBoxCrashCar
                };
            foreach (var control in controlsForBadRoad)
            { 
            control.BackgroundImage = Properties.Resources.Screenshot_10;
            }
        }

        private void PictureBoxHigwayRoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Локация выбрана");
            roadTrack1.Image = Properties.Resources.Three_lane_road_clean_01_2K_Base__6_2;
            roadTrack2.Image = Properties.Resources.Three_lane_road_clean_01_2K_Base__6_2;


            var controlsForHigwayRoad = new Control[]
                {
                player,
                AI1,
                AI2,
                AI3,
                AI4,
                AI5,
                AI6,
                AI7,
                pictureBoxIconMenu,
                pictureBoxIconShop,
                pictureBoxCrashCar
                };
            foreach (var control in controlsForHigwayRoad)
            {
                control.BackgroundImage = Properties.Resources.Screenshot_5;
            }
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
