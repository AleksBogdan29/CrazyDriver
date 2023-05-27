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

            var controlsForBackgroundFormMenu = new Control[]
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

            foreach (var control in controlsForBackgroundFormMenu)
            {
                control.Parent = pictureBoxBackgroundMenu;
                control.BackColor = Color.Transparent;
            }
        }

        private void LabelExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.Gray;
        }

        private void LabelSattings_Click(object sender, EventArgs e)
        {
            FormSattings sattings = new FormSattings();
            sattings.Show();
            this.Hide();
        }

        private void LabelGame_Click(object sender, EventArgs e)
        {
            FormWarning formWarning = new FormWarning();
            formWarning.Show();
            this.Hide();
        }

        private void LabelTraining_Click(object sender, EventArgs e)
        {
            FormTraining formTraining = new FormTraining();
            formTraining.Show();
            this.Hide();
        }
    }
}
