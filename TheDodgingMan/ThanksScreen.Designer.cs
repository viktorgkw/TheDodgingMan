namespace TheDodgingMan
{
    partial class TheDodgingManInfo
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
            this.gamelikecheck = new System.Windows.Forms.CheckBox();
            this.thankslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamelikecheck
            // 
            this.gamelikecheck.AutoSize = true;
            this.gamelikecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamelikecheck.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gamelikecheck.Location = new System.Drawing.Point(160, 164);
            this.gamelikecheck.Name = "gamelikecheck";
            this.gamelikecheck.Size = new System.Drawing.Size(269, 30);
            this.gamelikecheck.TabIndex = 1;
            this.gamelikecheck.Text = "Do you like the game?";
            this.gamelikecheck.UseVisualStyleBackColor = true;
            this.gamelikecheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // thankslabel
            // 
            this.thankslabel.AutoSize = true;
            this.thankslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thankslabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.thankslabel.Location = new System.Drawing.Point(225, 389);
            this.thankslabel.Name = "thankslabel";
            this.thankslabel.Size = new System.Drawing.Size(124, 29);
            this.thankslabel.TabIndex = 2;
            this.thankslabel.Text = "THANKS!";
            // 
            // TheDodgingManInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.thankslabel);
            this.Controls.Add(this.gamelikecheck);
            this.Name = "TheDodgingManInfo";
            this.Text = "TheDodgingMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox gamelikecheck;
        private System.Windows.Forms.Label thankslabel;
    }
}