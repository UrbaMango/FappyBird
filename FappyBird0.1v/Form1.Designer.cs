namespace FappyBird0._1v
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.overtext = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Pause = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopSecondPillar = new System.Windows.Forms.PictureBox();
            this.BottomSecondPillar = new System.Windows.Forms.PictureBox();
            this.TopFirstPillar = new System.Windows.Forms.PictureBox();
            this.BottomFirstPillar = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Cactus3 = new System.Windows.Forms.PictureBox();
            this.Cactus4 = new System.Windows.Forms.PictureBox();
            this.Cactus5 = new System.Windows.Forms.PictureBox();
            this.Cactus2 = new System.Windows.Forms.PictureBox();
            this.Cactus1 = new System.Windows.Forms.PictureBox();
            this.yourScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSecondPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSecondPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopFirstPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomFirstPillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // overtext
            // 
            this.overtext.AutoSize = true;
            this.overtext.BackColor = System.Drawing.Color.Transparent;
            this.overtext.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.overtext.Location = new System.Drawing.Point(271, 136);
            this.overtext.Name = "overtext";
            this.overtext.Size = new System.Drawing.Size(395, 86);
            this.overtext.TabIndex = 11;
            this.overtext.Text = "Game Over";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RestartButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RestartButton.Location = new System.Drawing.Point(385, 225);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(112, 40);
            this.RestartButton.TabIndex = 12;
            this.RestartButton.Text = "RestartButton";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Score: 0";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.Coral;
            this.Pause.Image = global::FappyBird0._1v.Properties.Resources.Paused;
            this.Pause.Location = new System.Drawing.Point(356, 35);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(141, 33);
            this.Pause.TabIndex = 22;
            this.Pause.Text = "              ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Image = global::FappyBird0._1v.Properties.Resources.StartButton;
            this.pictureBox2.Location = new System.Drawing.Point(331, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopSecondPillar
            // 
            this.TopSecondPillar.BackColor = System.Drawing.Color.DarkGreen;
            this.TopSecondPillar.Cursor = System.Windows.Forms.Cursors.No;
            this.TopSecondPillar.Image = global::FappyBird0._1v.Properties.Resources.PipeRotatedV2;
            this.TopSecondPillar.Location = new System.Drawing.Point(560, -8);
            this.TopSecondPillar.Name = "TopSecondPillar";
            this.TopSecondPillar.Size = new System.Drawing.Size(106, 107);
            this.TopSecondPillar.TabIndex = 10;
            this.TopSecondPillar.TabStop = false;
            // 
            // BottomSecondPillar
            // 
            this.BottomSecondPillar.BackColor = System.Drawing.Color.DarkGreen;
            this.BottomSecondPillar.Image = global::FappyBird0._1v.Properties.Resources.PipeV2;
            this.BottomSecondPillar.Location = new System.Drawing.Point(560, 225);
            this.BottomSecondPillar.Name = "BottomSecondPillar";
            this.BottomSecondPillar.Size = new System.Drawing.Size(106, 329);
            this.BottomSecondPillar.TabIndex = 9;
            this.BottomSecondPillar.TabStop = false;
            // 
            // TopFirstPillar
            // 
            this.TopFirstPillar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TopFirstPillar.BackColor = System.Drawing.Color.LimeGreen;
            this.TopFirstPillar.Cursor = System.Windows.Forms.Cursors.No;
            this.TopFirstPillar.Image = global::FappyBird0._1v.Properties.Resources.PipeRotatedV2;
            this.TopFirstPillar.Location = new System.Drawing.Point(180, -8);
            this.TopFirstPillar.Name = "TopFirstPillar";
            this.TopFirstPillar.Size = new System.Drawing.Size(106, 107);
            this.TopFirstPillar.TabIndex = 8;
            this.TopFirstPillar.TabStop = false;
            // 
            // BottomFirstPillar
            // 
            this.BottomFirstPillar.BackColor = System.Drawing.Color.LimeGreen;
            this.BottomFirstPillar.Image = global::FappyBird0._1v.Properties.Resources.PipeV2;
            this.BottomFirstPillar.Location = new System.Drawing.Point(180, 225);
            this.BottomFirstPillar.Name = "BottomFirstPillar";
            this.BottomFirstPillar.Size = new System.Drawing.Size(106, 278);
            this.BottomFirstPillar.TabIndex = 7;
            this.BottomFirstPillar.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Yellow;
            this.Bird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bird.Image = global::FappyBird0._1v.Properties.Resources.Bird2;
            this.Bird.Location = new System.Drawing.Point(44, 157);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(35, 30);
            this.Bird.TabIndex = 6;
            this.Bird.TabStop = false;
            // 
            // Cactus3
            // 
            this.Cactus3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cactus3.Image = ((System.Drawing.Image)(resources.GetObject("Cactus3.Image")));
            this.Cactus3.Location = new System.Drawing.Point(196, 297);
            this.Cactus3.Name = "Cactus3";
            this.Cactus3.Size = new System.Drawing.Size(50, 50);
            this.Cactus3.TabIndex = 3;
            this.Cactus3.TabStop = false;
            // 
            // Cactus4
            // 
            this.Cactus4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cactus4.Image = ((System.Drawing.Image)(resources.GetObject("Cactus4.Image")));
            this.Cactus4.Location = new System.Drawing.Point(504, 297);
            this.Cactus4.Name = "Cactus4";
            this.Cactus4.Size = new System.Drawing.Size(50, 50);
            this.Cactus4.TabIndex = 4;
            this.Cactus4.TabStop = false;
            // 
            // Cactus5
            // 
            this.Cactus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cactus5.Image = ((System.Drawing.Image)(resources.GetObject("Cactus5.Image")));
            this.Cactus5.Location = new System.Drawing.Point(724, 297);
            this.Cactus5.Name = "Cactus5";
            this.Cactus5.Size = new System.Drawing.Size(50, 50);
            this.Cactus5.TabIndex = 5;
            this.Cactus5.TabStop = false;
            // 
            // Cactus2
            // 
            this.Cactus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cactus2.Image = global::FappyBird0._1v.Properties.Resources.Cactuses;
            this.Cactus2.Location = new System.Drawing.Point(359, 297);
            this.Cactus2.Name = "Cactus2";
            this.Cactus2.Size = new System.Drawing.Size(50, 50);
            this.Cactus2.TabIndex = 2;
            this.Cactus2.TabStop = false;
            // 
            // Cactus1
            // 
            this.Cactus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Cactus1.Image = ((System.Drawing.Image)(resources.GetObject("Cactus1.Image")));
            this.Cactus1.Location = new System.Drawing.Point(44, 297);
            this.Cactus1.Name = "Cactus1";
            this.Cactus1.Size = new System.Drawing.Size(50, 50);
            this.Cactus1.TabIndex = 1;
            this.Cactus1.TabStop = false;
            // 
            // yourScore
            // 
            this.yourScore.AutoSize = true;
            this.yourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScore.Location = new System.Drawing.Point(317, 103);
            this.yourScore.Name = "yourScore";
            this.yourScore.Size = new System.Drawing.Size(180, 33);
            this.yourScore.TabIndex = 23;
            this.yourScore.Text = "Your Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(801, 451);
            this.Controls.Add(this.yourScore);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.overtext);
            this.Controls.Add(this.TopSecondPillar);
            this.Controls.Add(this.BottomSecondPillar);
            this.Controls.Add(this.TopFirstPillar);
            this.Controls.Add(this.BottomFirstPillar);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Cactus3);
            this.Controls.Add(this.Cactus4);
            this.Controls.Add(this.Cactus5);
            this.Controls.Add(this.Cactus2);
            this.Controls.Add(this.Cactus1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "FappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSecondPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSecondPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopFirstPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomFirstPillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Cactus1;
        private System.Windows.Forms.PictureBox Cactus2;
        private System.Windows.Forms.PictureBox Cactus3;
        private System.Windows.Forms.PictureBox Cactus4;
        private System.Windows.Forms.PictureBox Cactus5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BottomFirstPillar;
        private System.Windows.Forms.PictureBox TopFirstPillar;
        private System.Windows.Forms.PictureBox BottomSecondPillar;
        private System.Windows.Forms.PictureBox TopSecondPillar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label overtext;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Label yourScore;
    }
}

