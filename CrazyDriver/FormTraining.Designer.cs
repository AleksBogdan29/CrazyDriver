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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpedometerIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroundTraining = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxQuestionMark2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpedometerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark2)).BeginInit();
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerClick);
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
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
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
            // pictureBoxSpedometerIcon
            // 
            this.pictureBoxSpedometerIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSpedometerIcon.Image = global::CrazyDriver.Properties.Resources.iconMenu1;
            this.pictureBoxSpedometerIcon.Location = new System.Drawing.Point(12, 509);
            this.pictureBoxSpedometerIcon.Name = "pictureBoxSpedometerIcon";
            this.pictureBoxSpedometerIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxSpedometerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSpedometerIcon.TabIndex = 29;
            this.pictureBoxSpedometerIcon.TabStop = false;
            this.pictureBoxSpedometerIcon.Click += new System.EventHandler(this.pictureBoxSpedometerIcon_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(230, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "Избегай столкновений!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(88, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 34);
            this.label2.TabIndex = 39;
            this.label2.Text = "С увеличением счета скорость игрока растет .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(122, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Чем дальше проедешь - тем лучше приз!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(326, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 34);
            this.label4.TabIndex = 41;
            this.label4.Text = "Удачи!";
            // 
            // pictureBoxQuestionMark2
            // 
            this.pictureBoxQuestionMark2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxQuestionMark2.Image = global::CrazyDriver.Properties.Resources.questionMark;
            this.pictureBoxQuestionMark2.Location = new System.Drawing.Point(318, 468);
            this.pictureBoxQuestionMark2.Name = "pictureBoxQuestionMark2";
            this.pictureBoxQuestionMark2.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxQuestionMark2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQuestionMark2.TabIndex = 42;
            this.pictureBoxQuestionMark2.TabStop = false;
            this.pictureBoxQuestionMark2.Click += new System.EventHandler(this.pictureBoxQuestionMark2_Click);
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 603);
            this.Controls.Add(this.pictureBoxQuestionMark2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxQuestionMark);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.pictureBoxRightKey);
            this.Controls.Add(this.pictureBoxLeftKey);
            this.Controls.Add(this.labelTraining);
            this.Controls.Add(this.pictureBoxSpedometerIcon);
            this.Controls.Add(this.pictureBoxBackgroundTraining);
            this.Name = "FormTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTraining";
            this.Load += new System.EventHandler(this.FormTraining_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpedometerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackgroundTraining;
        private System.Windows.Forms.PictureBox pictureBoxSpedometerIcon;
        private System.Windows.Forms.Label labelTraining;
        private System.Windows.Forms.PictureBox pictureBoxLeftKey;
        private System.Windows.Forms.PictureBox pictureBoxRightKey;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark2;
    }
}