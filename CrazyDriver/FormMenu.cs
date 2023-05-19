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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
           
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var controls = new Control[]
           {
                labelMenuGame,
                labelCrazy,
                labelDriver,
                pictureBoxSpeedometerIcon,
                labelGame,
                labelSattings,
                labelExit,
                pictureBoxPoliceCar,
                pictureBoxCarForMenu,
                labelTraining
           };

            foreach (var control in controls)
            {
                control.Parent = pictureBoxBackgroundMenu;
                control.BackColor = Color.Transparent;
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LabelSattings_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            labelSattings.ForeColor = System.Drawing.Color.Red;

        }

        private void LabelSattings_MouseLeave(object sender, EventArgs e)
        {
            labelSattings.ForeColor = System.Drawing.Color.Gray;
        }

        private void LabelExit_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            labelExit.ForeColor = System.Drawing.Color.Red;

        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = System.Drawing.Color.Gray;
        }
        private void LabelGame_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            labelGame.ForeColor = System.Drawing.Color.Red;

        }

        private void LabelGame_MouseLeave(object sender, EventArgs e)
        {
            labelGame.ForeColor = System.Drawing.Color.Gray;
        }

        private void labelShop_Click(object sender, EventArgs e)
        {
            FormShop shop = new FormShop();
            shop.Show();
            this.Hide();
        }

        private void labelSattings_Click(object sender, EventArgs e)
        {
            FormSattings sattings = new FormSattings();
            sattings.Show();
            this.Hide();
        }

        private void labelGame_Click(object sender, EventArgs e)
        {
           
            FormWarning formWarning = new FormWarning();
            formWarning.Show();
            this.Hide();
        }

        private void labelTraining_MouseMove(object sender, MouseEventArgs e)
        {
            labelTraining.ForeColor = System.Drawing.Color.Red;
        }

        private void labelTrainig_MouseLeave(object sender, EventArgs e)
        {
            labelTraining.ForeColor = System.Drawing.Color.Gray;
        }

        private void labelTraining_Click(object sender, EventArgs e)
        {
            FormTraining formTraining = new FormTraining();
            formTraining.Show();
            this.Hide();
        }
    }
}
