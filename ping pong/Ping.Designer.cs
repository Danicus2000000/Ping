namespace Ping
{
    partial class Ping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ping));
            this.racket = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.playspace = new System.Windows.Forms.PictureBox();
            this.gameover_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playspace)).BeginInit();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(664, 944);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(0, 0);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(157, 42);
            this.score_lbl.TabIndex = 1;
            this.score_lbl.Text = "Score: 0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.ImageLocation = "";
            this.ball.Location = new System.Drawing.Point(479, 408);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // delay
            // 
            this.delay.Interval = 16;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // playspace
            // 
            this.playspace.Location = new System.Drawing.Point(5, 0);
            this.playspace.Name = "playspace";
            this.playspace.Size = new System.Drawing.Size(1350, 975);
            this.playspace.TabIndex = 3;
            this.playspace.TabStop = false;

            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_lbl.Location = new System.Drawing.Point(512, 384);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(287, 155);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over\r\n)-------------(\r\nF1- Retry\r\nF2- Add to Scoreboard\r\nESC- Quit";
            this.gameover_lbl.Visible = false;
            // 
            // Ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.gameover_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.playspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ping";
            this.Text = "Ping pong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pingpong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.PictureBox playspace;
        private System.Windows.Forms.Label gameover_lbl;
    }
}

