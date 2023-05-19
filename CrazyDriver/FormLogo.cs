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
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
            PlaySound();
            
        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            this.Text = null;
            this.ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;

           
            timer1.Interval = 17000;
            timer1.Enabled = true;
        }

        private void timerTick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void PlaySound()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream stream = assembly.GetManifestResourceStream(@"CrazyDriver.screensaveMrusic.wav");
            SoundPlayer soundPlayer = new SoundPlayer(stream);
            soundPlayer.Play();
        }
    }

}
