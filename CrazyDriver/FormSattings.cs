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
    public partial class FormSattings : Form
    {
        public FormSattings()
        {
            InitializeComponent();
        }

        private void FormSattings_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            var contlolsForBackgroundFormSattings = new Control[]
         {
                labelCrazy,
                labelDriver,
                pictureBoxSpeedometerIcon,
                labelSattings,
                pictureBoxIconMenu,
                checkBoxMute
              
         };

            foreach (var control in contlolsForBackgroundFormSattings)
            {
                control.Parent = pictureBoxBackgroundSattings;
                control.BackColor = Color.Transparent;
            }
        }

        private void PictureBoxIconMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void CheckBox_MouseMove(object sender, MouseEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            checkBox.ForeColor = Color.Red;
        }

        private void CheckBoxl_MouseLeave(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            checkBox.ForeColor = Color.Gray;
        }


    }
}
