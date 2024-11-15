namespace Ping
{
    partial class leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leaderboard));
            this.title_lbl = new System.Windows.Forms.Label();
            this.peeps_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(60, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(70, 48);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Entries\r\n)--------(";
            // 
            // peeps_lbl
            // 
            this.peeps_lbl.AutoSize = true;
            this.peeps_lbl.Location = new System.Drawing.Point(2, 68);
            this.peeps_lbl.Name = "peeps_lbl";
            this.peeps_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peeps_lbl.Size = new System.Drawing.Size(0, 13);
            this.peeps_lbl.TabIndex = 1;
            // 
            // leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(220, 343);
            this.Controls.Add(this.peeps_lbl);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "leaderboard";
            this.ShowIcon = false;
            this.Text = "Leaderboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.leaderboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaderboard_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label peeps_lbl;
    }
}