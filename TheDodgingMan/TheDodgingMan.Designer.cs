namespace TheDodgingMan
{
    partial class TheDodgingMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheDodgingMan));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tdmOfficial = new System.Windows.Forms.PictureBox();
            this.dodgebox1 = new System.Windows.Forms.PictureBox();
            this.dodgebox2 = new System.Windows.Forms.PictureBox();
            this.dodgebox3 = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heartscountlabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.heartsatend = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tdmOfficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tdmOfficial
            // 
            this.tdmOfficial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tdmOfficial.BackgroundImage")));
            this.tdmOfficial.Location = new System.Drawing.Point(197, 498);
            this.tdmOfficial.Name = "tdmOfficial";
            this.tdmOfficial.Size = new System.Drawing.Size(48, 48);
            this.tdmOfficial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tdmOfficial.TabIndex = 5;
            this.tdmOfficial.TabStop = false;
            this.tdmOfficial.Click += new System.EventHandler(this.tdmOfficial_Click);
            // 
            // dodgebox1
            // 
            this.dodgebox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dodgebox1.BackgroundImage")));
            this.dodgebox1.Location = new System.Drawing.Point(117, 203);
            this.dodgebox1.Name = "dodgebox1";
            this.dodgebox1.Size = new System.Drawing.Size(64, 64);
            this.dodgebox1.TabIndex = 6;
            this.dodgebox1.TabStop = false;
            // 
            // dodgebox2
            // 
            this.dodgebox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dodgebox2.BackgroundImage")));
            this.dodgebox2.Location = new System.Drawing.Point(283, 117);
            this.dodgebox2.Name = "dodgebox2";
            this.dodgebox2.Size = new System.Drawing.Size(64, 64);
            this.dodgebox2.TabIndex = 7;
            this.dodgebox2.TabStop = false;
            // 
            // dodgebox3
            // 
            this.dodgebox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dodgebox3.BackgroundImage")));
            this.dodgebox3.Location = new System.Drawing.Point(270, 399);
            this.dodgebox3.Name = "dodgebox3";
            this.dodgebox3.Size = new System.Drawing.Size(64, 64);
            this.dodgebox3.TabIndex = 8;
            this.dodgebox3.TabStop = false;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("Perpetua Titling MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Cyan;
            this.over.Location = new System.Drawing.Point(94, 219);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(288, 48);
            this.over.TabIndex = 9;
            this.over.Text = "Game Over!";
            this.over.Click += new System.EventHandler(this.GameOverLabel_Click);
            // 
            // heart1
            // 
            this.heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart1.BackgroundImage")));
            this.heart1.Location = new System.Drawing.Point(149, 399);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(32, 32);
            this.heart1.TabIndex = 10;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart2.BackgroundImage")));
            this.heart2.Location = new System.Drawing.Point(270, 276);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(32, 32);
            this.heart2.TabIndex = 11;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart3.BackgroundImage")));
            this.heart3.Location = new System.Drawing.Point(197, 60);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(32, 32);
            this.heart3.TabIndex = 12;
            this.heart3.TabStop = false;
            // 
            // heartscountlabel
            // 
            this.heartscountlabel.BackColor = System.Drawing.Color.Transparent;
            this.heartscountlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.heartscountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartscountlabel.ForeColor = System.Drawing.Color.IndianRed;
            this.heartscountlabel.Location = new System.Drawing.Point(0, -1);
            this.heartscountlabel.Name = "heartscountlabel";
            this.heartscountlabel.Size = new System.Drawing.Size(107, 34);
            this.heartscountlabel.TabIndex = 13;
            this.heartscountlabel.Text = "Hearts=0";
            this.heartscountlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Transparent;
            this.RestartButton.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.RestartButton.Location = new System.Drawing.Point(185, 314);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(96, 48);
            this.RestartButton.TabIndex = 14;
            this.RestartButton.Text = "Back to menu";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // heartsatend
            // 
            this.heartsatend.AutoSize = true;
            this.heartsatend.Font = new System.Drawing.Font("Microsoft YaHei", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heartsatend.Location = new System.Drawing.Point(172, 276);
            this.heartsatend.Name = "heartsatend";
            this.heartsatend.Size = new System.Drawing.Size(130, 19);
            this.heartsatend.TabIndex = 15;
            this.heartsatend.Text = "You got 0 hearts!";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(187, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 48);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TheDodgingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(455, 590);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.heartsatend);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.heartscountlabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.dodgebox3);
            this.Controls.Add(this.dodgebox2);
            this.Controls.Add(this.dodgebox1);
            this.Controls.Add(this.tdmOfficial);
            this.Name = "TheDodgingMan";
            this.Text = "TheDodgingMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tdmOfficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodgebox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox tdmOfficial;
        private System.Windows.Forms.PictureBox dodgebox1;
        private System.Windows.Forms.PictureBox dodgebox2;
        private System.Windows.Forms.PictureBox dodgebox3;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Label heartscountlabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label heartsatend;
        private System.Windows.Forms.Button ExitButton;
    }
}

