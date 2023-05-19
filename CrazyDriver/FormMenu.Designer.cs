using System;
using System.Windows.Forms;

namespace CrazyDriver
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMenuGame = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.labelSattings = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelCrazy = new System.Windows.Forms.Label();
            this.labelDriver = new System.Windows.Forms.Label();
            this.labelTraining = new System.Windows.Forms.Label();
            this.pictureBoxCarForMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoliceCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeedometerIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroundMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoliceCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeedometerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenuGame
            // 
            this.labelMenuGame.AutoSize = true;
            this.labelMenuGame.BackColor = System.Drawing.Color.Transparent;
            this.labelMenuGame.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenuGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelMenuGame.Location = new System.Drawing.Point(12, 9);
            this.labelMenuGame.Name = "labelMenuGame";
            this.labelMenuGame.Size = new System.Drawing.Size(160, 76);
            this.labelMenuGame.TabIndex = 3;
            this.labelMenuGame.Text = "Меню";
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGame.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelGame.Location = new System.Drawing.Point(297, 105);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(139, 50);
            this.labelGame.TabIndex = 19;
            this.labelGame.Text = "Играть";
            this.labelGame.Click += new System.EventHandler(this.labelGame_Click);
            this.labelGame.MouseLeave += new System.EventHandler(this.LabelGame_MouseLeave);
            this.labelGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelGame_MouseMove);
            // 
            // labelSattings
            // 
            this.labelSattings.AutoSize = true;
            this.labelSattings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSattings.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSattings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelSattings.Location = new System.Drawing.Point(275, 242);
            this.labelSattings.Name = "labelSattings";
            this.labelSattings.Size = new System.Drawing.Size(187, 50);
            this.labelSattings.TabIndex = 21;
            this.labelSattings.Text = "Настройки";
            this.labelSattings.Click += new System.EventHandler(this.labelSattings_Click);
            this.labelSattings.MouseLeave += new System.EventHandler(this.LabelSattings_MouseLeave);
            this.labelSattings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelSattings_MouseMove);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelExit.Location = new System.Drawing.Point(313, 310);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(110, 50);
            this.labelExit.TabIndex = 22;
            this.labelExit.Text = "Выход";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.LabelExit_MouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelExit_MouseMove);
            // 
            // labelCrazy
            // 
            this.labelCrazy.AutoSize = true;
            this.labelCrazy.BackColor = System.Drawing.Color.Transparent;
            this.labelCrazy.Font = new System.Drawing.Font("Elephant", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrazy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelCrazy.Location = new System.Drawing.Point(593, 520);
            this.labelCrazy.Name = "labelCrazy";
            this.labelCrazy.Size = new System.Drawing.Size(127, 42);
            this.labelCrazy.TabIndex = 23;
            this.labelCrazy.Text = "Crazy";
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.BackColor = System.Drawing.Color.Transparent;
            this.labelDriver.Font = new System.Drawing.Font("Elephant", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelDriver.Location = new System.Drawing.Point(553, 552);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(137, 42);
            this.labelDriver.TabIndex = 24;
            this.labelDriver.Text = "Driver";
            // 
            // labelTraining
            // 
            this.labelTraining.AutoSize = true;
            this.labelTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTraining.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTraining.Location = new System.Drawing.Point(297, 174);
            this.labelTraining.Name = "labelTraining";
            this.labelTraining.Size = new System.Drawing.Size(155, 50);
            this.labelTraining.TabIndex = 28;
            this.labelTraining.Text = "Обучение";
            this.labelTraining.Click += new System.EventHandler(this.labelTraining_Click);
            this.labelTraining.MouseLeave += new System.EventHandler(this.labelTrainig_MouseLeave);
            this.labelTraining.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTraining_MouseMove);
            // 
            // pictureBoxCarForMenu
            // 
            this.pictureBoxCarForMenu.Image = global::CrazyDriver.Properties.Resources.carForMenu;
            this.pictureBoxCarForMenu.Location = new System.Drawing.Point(524, 324);
            this.pictureBoxCarForMenu.Name = "pictureBoxCarForMenu";
            this.pictureBoxCarForMenu.Size = new System.Drawing.Size(166, 127);
            this.pictureBoxCarForMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCarForMenu.TabIndex = 27;
            this.pictureBoxCarForMenu.TabStop = false;
            // 
            // pictureBoxPoliceCar
            // 
            this.pictureBoxPoliceCar.Image = global::CrazyDriver.Properties.Resources.policeCarForMenu;
            this.pictureBoxPoliceCar.Location = new System.Drawing.Point(0, 424);
            this.pictureBoxPoliceCar.Name = "pictureBoxPoliceCar";
            this.pictureBoxPoliceCar.Size = new System.Drawing.Size(200, 152);
            this.pictureBoxPoliceCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPoliceCar.TabIndex = 26;
            this.pictureBoxPoliceCar.TabStop = false;
            // 
            // pictureBoxSpeedometerIcon
            // 
            this.pictureBoxSpeedometerIcon.Image = global::CrazyDriver.Properties.Resources.speedometeIrcon;
            this.pictureBoxSpeedometerIcon.Location = new System.Drawing.Point(432, 505);
            this.pictureBoxSpeedometerIcon.Name = "pictureBoxSpeedometerIcon";
            this.pictureBoxSpeedometerIcon.Size = new System.Drawing.Size(115, 89);
            this.pictureBoxSpeedometerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSpeedometerIcon.TabIndex = 25;
            this.pictureBoxSpeedometerIcon.TabStop = false;
            // 
            // pictureBoxBackgroundMenu
            // 
            this.pictureBoxBackgroundMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackgroundMenu.Image = global::CrazyDriver.Properties.Resources.backGroundMenu;
            this.pictureBoxBackgroundMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackgroundMenu.Name = "pictureBoxBackgroundMenu";
            this.pictureBoxBackgroundMenu.Size = new System.Drawing.Size(732, 603);
            this.pictureBoxBackgroundMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgroundMenu.TabIndex = 0;
            this.pictureBoxBackgroundMenu.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 603);
            this.Controls.Add(this.labelTraining);
            this.Controls.Add(this.pictureBoxCarForMenu);
            this.Controls.Add(this.pictureBoxPoliceCar);
            this.Controls.Add(this.pictureBoxSpeedometerIcon);
            this.Controls.Add(this.labelDriver);
            this.Controls.Add(this.labelCrazy);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelSattings);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.labelMenuGame);
            this.Controls.Add(this.pictureBoxBackgroundMenu);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoliceCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeedometerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackgroundMenu;
        private System.Windows.Forms.Label labelMenuGame;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label labelSattings;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelCrazy;
        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.PictureBox pictureBoxSpeedometerIcon;
        private System.Windows.Forms.PictureBox pictureBoxPoliceCar;
        private System.Windows.Forms.PictureBox pictureBoxCarForMenu;
        private Label labelTraining;
    }
}