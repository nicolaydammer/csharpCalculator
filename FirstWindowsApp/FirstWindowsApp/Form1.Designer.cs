namespace FirstWindowsApp
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.naamLbl = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.showNaamLbl = new System.Windows.Forms.Label();
            this.txtBoxPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(325, 470);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(116, 43);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // naamLbl
            // 
            this.naamLbl.AutoSize = true;
            this.naamLbl.Location = new System.Drawing.Point(262, 277);
            this.naamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.naamLbl.Name = "naamLbl";
            this.naamLbl.Size = new System.Drawing.Size(116, 25);
            this.naamLbl.TabIndex = 1;
            this.naamLbl.Text = "Username:";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(430, 277);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(212, 31);
            this.TextBoxUserName.TabIndex = 2;
            // 
            // showNaamLbl
            // 
            this.showNaamLbl.AutoSize = true;
            this.showNaamLbl.Location = new System.Drawing.Point(482, 377);
            this.showNaamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showNaamLbl.Name = "showNaamLbl";
            this.showNaamLbl.Size = new System.Drawing.Size(0, 25);
            this.showNaamLbl.TabIndex = 3;
            // 
            // txtBoxPasswd
            // 
            this.txtBoxPasswd.Location = new System.Drawing.Point(430, 337);
            this.txtBoxPasswd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPasswd.Name = "txtBoxPasswd";
            this.txtBoxPasswd.Size = new System.Drawing.Size(212, 31);
            this.txtBoxPasswd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(526, 470);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 43);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 752);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.txtBoxPasswd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showNaamLbl);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.naamLbl);
            this.Controls.Add(this.LoginBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label naamLbl;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.Label showNaamLbl;
        private System.Windows.Forms.TextBox txtBoxPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
    }
}

