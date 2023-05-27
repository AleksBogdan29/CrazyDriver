namespace CrazyDriver
{
    partial class FormTraining
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
            this.components = new System.ComponentModel.Container();
            this.labelTraining = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.timerTraining = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxIconMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroundTraining = new System.Windows.Forms.PictureBox();
            this.labelTextFirst = new System.Windows.Forms.Label();
            this.labelTextSecond = new System.Windows.Forms.Label();
            this.labelTextThird = new System.Windows.Forms.Label();
            this.labelTextFourth = new System.Windows.Forms.Label();
            this.pictureBoxQuestionMarkIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTraining
            // 
            this.labelTraining.AutoSize = true;
            this.labelTraining.BackColor = System.Drawing.Color.Transparent;
            this.labelTraining.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTraining.Location = new System.Drawing.Point(12, 9);
            this.labelTraining.Name = "labelTraining";
            this.labelTraining.Size = new System.Drawing.Size(328, 76);
            this.labelTraining.TabIndex = 30;
            this.labelTraining.Text = "Как играть?";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelLeft.Location = new System.Drawing.Point(12, 343);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(251, 64);
            this.labelLeft.TabIndex = 33;
            this.labelLeft.Text = "Двигаться влево\r\n\r\n";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelRight.Location = new System.Drawing.Point(439, 343);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(268, 32);
            this.labelRight.TabIndex = 34;
            this.labelRight.Text = "Двигаться вправо";
            // 
            // timerTraining
            // 
            this.timerTraining.Tick += new System.EventHandler(this.TimerTraining_Tick);
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuestionMark.Image = global::CrazyDriver.Properties.Resources.questionMark;
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(318, 468);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQuestionMark.TabIndex = 37;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.PictureBoxQuestionMark_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::CrazyDriver.Properties.Resources.audiForTrafic;
            this.pictureBoxCar.Location = new System.Drawing.Point(318, 132);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(106, 213);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCar.TabIndex = 35;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxRightKey
            // 
            this.pictureBoxRightKey.Image = global::CrazyDriver.Properties.Resources.rightKey;
            this.pictureBoxRightKey.Location = new System.Drawing.Point(556, 385);
            this.pictureBoxRightKey.Name = "pictureBoxRightKey";
            this.pictureBoxRightKey.Size = new System.Drawing.Size(76, 76);
            this.pictureBoxRightKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightKey.TabIndex = 32;
            this.pictureBoxRightKey.TabStop = false;
            // 
            // pictureBoxLeftKey
            // 
            this.pictureBoxLeftKey.Image = global::CrazyDriver.Properties.Resources.leftKey;
            this.pictureBoxLeftKey.Location = new System.Drawing.Point(94, 385);
            this.pictureBoxLeftKey.Name = "pictureBoxLeftKey";
            this.pictureBoxLeftKey.Size = new System.Drawing.Size(76, 76);
            this.pictureBoxLeftKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftKey.TabIndex = 31;
            this.pictureBoxLeftKey.TabStop = false;
            // 
            // pictureBoxIconMenu
            // 
            this.pictureBoxIconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIconMenu.Image = global::CrazyDriver.Properties.Resources.iconMenu1;
            this.pictureBoxIconMenu.Location = new System.Drawing.Point(12, 509);
            this.pictureBoxIconMenu.Name = "pictureBoxIconMenu";
            this.pictureBoxIconMenu.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIconMenu.TabIndex = 29;
            this.pictureBoxIconMenu.TabStop = false;
            this.pictureBoxIconMenu.Click += new System.EventHandler(this.PictureBoxIconMenu_Click);
            // 
            // pictureBoxBackgroundTraining
            // 
            this.pictureBoxBackgroundTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackgroundTraining.Image = global::CrazyDriver.Properties.Resources.backgroundForTraining;
            this.pictureBoxBackgroundTraining.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackgroundTraining.Name = "pictureBoxBackgroundTraining";
            this.pictureBoxBackgroundTraining.Size = new System.Drawing.Size(732, 603);
            this.pictureBoxBackgroundTraining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgroundTraining.TabIndex = 0;
            this.pictureBoxBackgroundTraining.TabStop = false;
            // 
            // labelTextFirst
            // 
            this.labelTextFirst.AutoSize = true;
            this.labelTextFirst.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTextFirst.Location = new System.Drawing.Point(230, 163);
            this.labelTextFirst.Name = "labelTextFirst";
            this.labelTextFirst.Size = new System.Drawing.Size(307, 34);
            this.labelTextFirst.TabIndex = 38;
            this.labelTextFirst.Text = "Избегай столкновений!";
            // 
            // labelTextSecond
            // 
            this.labelTextSecond.AutoSize = true;
            this.labelTextSecond.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTextSecond.Location = new System.Drawing.Point(88, 213);
            this.labelTextSecond.Name = "labelTextSecond";
            this.labelTextSecond.Size = new System.Drawing.Size(580, 34);
            this.labelTextSecond.TabIndex = 39;
            this.labelTextSecond.Text = "С увеличением счета скорость игрока растет .";
            // 
            // labelTextThird
            // 
            this.labelTextThird.AutoSize = true;
            this.labelTextThird.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextThird.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTextThird.Location = new System.Drawing.Point(122, 266);
            this.labelTextThird.Name = "labelTextThird";
            this.labelTextThird.Size = new System.Drawing.Size(510, 34);
            this.labelTextThird.TabIndex = 40;
            this.labelTextThird.Text = "Чем дальше проедешь - тем лучше приз!";
            // 
            // labelTextFourth
            // 
            this.labelTextFourth.AutoSize = true;
            this.labelTextFourth.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFourth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.labelTextFourth.Location = new System.Drawing.Point(326, 322);
            this.labelTextFourth.Name = "labelTextFourth";
            this.labelTextFourth.Size = new System.Drawing.Size(98, 34);
            this.labelTextFourth.TabIndex = 41;
            this.labelTextFourth.Text = "Удачи!";
            // 
            // pictureBoxQuestionMarkIcon
            // 
            this.pictureBoxQuestionMarkIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuestionMarkIcon.Image = global::CrazyDriver.Properties.Resources.questionMark;
            this.pictureBoxQuestionMarkIcon.Location = new System.Drawing.Point(318, 468);
            this.pictureBoxQuestionMarkIcon.Name = "pictureBoxQuestionMarkIcon";
            this.pictureBoxQuestionMarkIcon.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxQuestionMarkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQuestionMarkIcon.TabIndex = 42;
            this.pictureBoxQuestionMarkIcon.TabStop = false;
            this.pictureBoxQuestionMarkIcon.Click += new System.EventHandler(this.PictureBoxQuestionMark2_Click);
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 603);
            this.Controls.Add(this.pictureBoxQuestionMarkIcon);
            this.Controls.Add(this.labelTextFourth);
            this.Controls.Add(this.labelTextThird);
            this.Controls.Add(this.labelTextSecond);
            this.Controls.Add(this.labelTextFirst);
            this.Controls.Add(this.pictureBoxQuestionMark);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.pictureBoxRightKey);
            this.Controls.Add(this.pictureBoxLeftKey);
            this.Controls.Add(this.labelTraining);
            this.Controls.Add(this.pictureBoxIconMenu);
            this.Controls.Add(this.pictureBoxBackgroundTraining);
            this.Name = "FormTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTraining";
            this.Load += new System.EventHandler(this.FormTraining_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMarkIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackgroundTraining;
        private System.Windows.Forms.PictureBox pictureBoxIconMenu;
        private System.Windows.Forms.Label labelTraining;
        private System.Windows.Forms.PictureBox pictureBoxLeftKey;
        private System.Windows.Forms.PictureBox pictureBoxRightKey;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Timer timerTraining;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
        private System.Windows.Forms.Label labelTextFirst;
        private System.Windows.Forms.Label labelTextSecond;
        private System.Windows.Forms.Label labelTextThird;
        private System.Windows.Forms.Label labelTextFourth;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMarkIcon;
    }
}