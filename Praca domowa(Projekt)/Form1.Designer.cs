namespace Praca_domowa_Projekt_
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.addHomework = new System.Windows.Forms.Button();
            this.myHomework = new System.Windows.Forms.Button();
            this.changeUrl = new System.Windows.Forms.Button();
            this.urlName = new System.Windows.Forms.TextBox();
            this.pathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(72, 18);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1167, 385);
            this.webBrowser1.TabIndex = 0;
            // 
            // addHomework
            // 
            this.addHomework.Location = new System.Drawing.Point(72, 472);
            this.addHomework.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addHomework.Name = "addHomework";
            this.addHomework.Size = new System.Drawing.Size(249, 106);
            this.addHomework.TabIndex = 1;
            this.addHomework.Text = "Add Homework";
            this.addHomework.UseVisualStyleBackColor = true;
            this.addHomework.Click += new System.EventHandler(this.AddHomework_Click);
            // 
            // myHomework
            // 
            this.myHomework.Location = new System.Drawing.Point(942, 472);
            this.myHomework.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myHomework.Name = "myHomework";
            this.myHomework.Size = new System.Drawing.Size(297, 106);
            this.myHomework.TabIndex = 2;
            this.myHomework.Text = "What is my homework";
            this.myHomework.UseVisualStyleBackColor = true;
            this.myHomework.Click += new System.EventHandler(this.MyHomework_Click);
            // 
            // changeUrl
            // 
            this.changeUrl.Location = new System.Drawing.Point(582, 409);
            this.changeUrl.Margin = new System.Windows.Forms.Padding(2);
            this.changeUrl.Name = "changeUrl";
            this.changeUrl.Size = new System.Drawing.Size(81, 42);
            this.changeUrl.TabIndex = 3;
            this.changeUrl.Text = "Change";
            this.changeUrl.UseVisualStyleBackColor = true;
            this.changeUrl.Click += new System.EventHandler(this.ChangeUrl_Click);
            // 
            // urlName
            // 
            this.urlName.BackColor = System.Drawing.Color.Wheat;
            this.urlName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlName.Location = new System.Drawing.Point(350, 128);
            this.urlName.Margin = new System.Windows.Forms.Padding(2);
            this.urlName.Name = "urlName";
            this.urlName.Size = new System.Drawing.Size(525, 19);
            this.urlName.TabIndex = 4;
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(878, 118);
            this.pathBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(81, 37);
            this.pathBtn.TabIndex = 5;
            this.pathBtn.Text = "Go";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 685);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.urlName);
            this.Controls.Add(this.changeUrl);
            this.Controls.Add(this.myHomework);
            this.Controls.Add(this.addHomework);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button addHomework;
        private System.Windows.Forms.Button myHomework;
        private System.Windows.Forms.Button changeUrl;
        private System.Windows.Forms.TextBox urlName;
        private System.Windows.Forms.Button pathBtn;
    }
}

