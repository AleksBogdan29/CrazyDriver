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



            timer1.Interval = 10000;
            timer1.Enabled = true;
        }

        private void TimerClick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           FormGame formGame = new FormGame();
            formGame.Show();
            this.Hide();
        }
    }
}
