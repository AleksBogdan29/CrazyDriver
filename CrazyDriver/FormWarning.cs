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
    public partial class FormWarning : Form
    {
        public FormWarning()
        {
            InitializeComponent();
        }

        private void FormWarning_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            timerWarning.Interval = 10000;
            timerWarning.Enabled = true;
        }

        private void TimerWarning_Tick(object sender, EventArgs e)
        {
            timerWarning.Enabled = false;
           FormGame formGame = new FormGame();
            formGame.Show();
            this.Hide();
        }
    }
}
