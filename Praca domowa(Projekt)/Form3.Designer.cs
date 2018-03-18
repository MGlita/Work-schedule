namespace Praca_domowa_Projekt_
{
    partial class Form3
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
            this.hworkCmBox = new System.Windows.Forms.ComboBox();
            this.hworkDescTxtBox = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.allDoneLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hworkCmBox
            // 
            this.hworkCmBox.Enabled = false;
            this.hworkCmBox.FormattingEnabled = true;
            this.hworkCmBox.Location = new System.Drawing.Point(134, 63);
            this.hworkCmBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hworkCmBox.Name = "hworkCmBox";
            this.hworkCmBox.Size = new System.Drawing.Size(247, 28);
            this.hworkCmBox.TabIndex = 0;
            // 
            // hworkDescTxtBox
            // 
            this.hworkDescTxtBox.Location = new System.Drawing.Point(75, 105);
            this.hworkDescTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hworkDescTxtBox.Multiline = true;
            this.hworkDescTxtBox.Name = "hworkDescTxtBox";
            this.hworkDescTxtBox.Size = new System.Drawing.Size(384, 232);
            this.hworkDescTxtBox.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(348, 397);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(112, 35);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(75, 397);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(112, 35);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(212, 446);
            this.doneBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(112, 35);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done!";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // allDoneLbl
            // 
            this.allDoneLbl.AutoSize = true;
            this.allDoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.allDoneLbl.Location = new System.Drawing.Point(206, 393);
            this.allDoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allDoneLbl.Name = "allDoneLbl";
            this.allDoneLbl.Size = new System.Drawing.Size(133, 33);
            this.allDoneLbl.TabIndex = 5;
            this.allDoneLbl.Text = "All Done!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 522);
            this.Controls.Add(this.allDoneLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.hworkDescTxtBox);
            this.Controls.Add(this.hworkCmBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "My Homework";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hworkCmBox;
        private System.Windows.Forms.TextBox hworkDescTxtBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label allDoneLbl;
    }
}