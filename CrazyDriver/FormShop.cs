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
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var controls = new Control[]
        {
                labelChooseCar,
                labelCrazy,
                labelDriver,
                pictureBoxSpeedometerIcon,
                pictureBoxChevrolet,
                pictureBoxNissan,
                pictureBoxKoenigsegg,
                pictureBoxLamborghini,
                labelNissan,
                labelChevrolet,
                labelKoenigsegg,
                labelLamborghini,
                pictureBoxIconMenu
        };

            foreach (var control in controls)
            {
                control.Parent = pictureBoxBackgroundShop;
                control.BackColor = Color.Transparent;
            }
        }

        private void pictureBoxIconMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        
    }
}
