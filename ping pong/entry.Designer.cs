namespace Ping
{
    partial class entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entry));
            this.title_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.cofirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(268, 13);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Please enter a three character name for the scoreboard";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(112, 25);
            this.name_txt.MaxLength = 3;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(54, 20);
            this.name_txt.TabIndex = 1;
            // 
            // cofirm_btn
            // 
            this.cofirm_btn.Location = new System.Drawing.Point(112, 51);
            this.cofirm_btn.Name = "cofirm_btn";
            this.cofirm_btn.Size = new System.Drawing.Size(54, 24);
            this.cofirm_btn.TabIndex = 2;
            this.cofirm_btn.Text = "Ok";
            this.cofirm_btn.UseVisualStyleBackColor = true;
            this.cofirm_btn.Click += new System.EventHandler(this.cofirm_btn_Click);
            // 
            // entry
            // 
            this.AcceptButton = this.cofirm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 99);
            this.Controls.Add(this.cofirm_btn);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.title_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "entry";
            this.ShowIcon = false;
            this.Text = "Data entry";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entry_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button cofirm_btn;
    }
}