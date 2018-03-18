namespace Praca_domowa_Projekt_
{
    partial class Form2
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
            this.subjectListCmBox = new System.Windows.Forms.ComboBox();
            this.homeworkDescTxtBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.deleteSubjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectListCmBox
            // 
            this.subjectListCmBox.FormattingEnabled = true;
            this.subjectListCmBox.Location = new System.Drawing.Point(68, 80);
            this.subjectListCmBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subjectListCmBox.Name = "subjectListCmBox";
            this.subjectListCmBox.Size = new System.Drawing.Size(285, 28);
            this.subjectListCmBox.TabIndex = 0;
            // 
            // homeworkDescTxtBox
            // 
            this.homeworkDescTxtBox.Location = new System.Drawing.Point(18, 121);
            this.homeworkDescTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeworkDescTxtBox.Multiline = true;
            this.homeworkDescTxtBox.Name = "homeworkDescTxtBox";
            this.homeworkDescTxtBox.Size = new System.Drawing.Size(418, 165);
            this.homeworkDescTxtBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(52, 317);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(138, 35);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(266, 317);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(140, 35);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(359, 41);
            this.addSubjectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(75, 35);
            this.addSubjectBtn.TabIndex = 4;
            this.addSubjectBtn.Text = "Add";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // deleteSubjectBtn
            // 
            this.deleteSubjectBtn.Location = new System.Drawing.Point(359, 80);
            this.deleteSubjectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSubjectBtn.Name = "deleteSubjectBtn";
            this.deleteSubjectBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteSubjectBtn.TabIndex = 5;
            this.deleteSubjectBtn.Text = "Delete";
            this.deleteSubjectBtn.UseVisualStyleBackColor = true;
            this.deleteSubjectBtn.Click += new System.EventHandler(this.DeleteSubjectBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 429);
            this.Controls.Add(this.deleteSubjectBtn);
            this.Controls.Add(this.addSubjectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.homeworkDescTxtBox);
            this.Controls.Add(this.subjectListCmBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Add Homework";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectListCmBox;
        private System.Windows.Forms.TextBox homeworkDescTxtBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.Button deleteSubjectBtn;
    }
}