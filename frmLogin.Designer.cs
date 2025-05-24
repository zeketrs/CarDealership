namespace CarDealership
{
    partial class frmLogin
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
            this.chkShowPasswordLogin = new System.Windows.Forms.CheckBox();
            this.btnClearActLogin = new System.Windows.Forms.Button();
            this.btnActLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.lblUserPwLogin = new System.Windows.Forms.Label();
            this.lblUserNLogin = new System.Windows.Forms.Label();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.lblRegistrationLabel = new System.Windows.Forms.Label();
            this.lblGuestlogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkShowPasswordLogin
            // 
            this.chkShowPasswordLogin.AutoSize = true;
            this.chkShowPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkShowPasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPasswordLogin.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPasswordLogin.Location = new System.Drawing.Point(155, 183);
            this.chkShowPasswordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPasswordLogin.Name = "chkShowPasswordLogin";
            this.chkShowPasswordLogin.Size = new System.Drawing.Size(109, 24);
            this.chkShowPasswordLogin.TabIndex = 23;
            this.chkShowPasswordLogin.Text = "Show Password";
            this.chkShowPasswordLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkShowPasswordLogin.UseVisualStyleBackColor = false;
            this.chkShowPasswordLogin.CheckedChanged += new System.EventHandler(this.chkShowPasswordLogin_CheckedChanged);
            // 
            // btnClearActLogin
            // 
            this.btnClearActLogin.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.btnClearActLogin.Location = new System.Drawing.Point(65, 291);
            this.btnClearActLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearActLogin.Name = "btnClearActLogin";
            this.btnClearActLogin.Size = new System.Drawing.Size(170, 27);
            this.btnClearActLogin.TabIndex = 21;
            this.btnClearActLogin.Text = "Clear";
            this.btnClearActLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearActLogin.UseVisualStyleBackColor = true;
            this.btnClearActLogin.Click += new System.EventHandler(this.btnClearActLogin_Click);
            // 
            // btnActLogin
            // 
            this.btnActLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActLogin.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.btnActLogin.Location = new System.Drawing.Point(65, 252);
            this.btnActLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnActLogin.Name = "btnActLogin";
            this.btnActLogin.Size = new System.Drawing.Size(170, 27);
            this.btnActLogin.TabIndex = 20;
            this.btnActLogin.Text = "Login";
            this.btnActLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActLogin.UseVisualStyleBackColor = false;
            this.btnActLogin.Click += new System.EventHandler(this.btnActLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(42, 152);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '⬤';
            this.txtPassword.Size = new System.Drawing.Size(224, 20);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Tag = "Password";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(42, 99);
            this.txtUserLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserLogin.MaxLength = 20;
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(224, 20);
            this.txtUserLogin.TabIndex = 17;
            this.txtUserLogin.Tag = "UserName";
            // 
            // lblUserPwLogin
            // 
            this.lblUserPwLogin.AutoSize = true;
            this.lblUserPwLogin.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.lblUserPwLogin.Location = new System.Drawing.Point(38, 127);
            this.lblUserPwLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPwLogin.Name = "lblUserPwLogin";
            this.lblUserPwLogin.Size = new System.Drawing.Size(83, 29);
            this.lblUserPwLogin.TabIndex = 14;
            this.lblUserPwLogin.Text = "Password:";
            this.lblUserPwLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserNLogin
            // 
            this.lblUserNLogin.AutoSize = true;
            this.lblUserNLogin.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNLogin.Location = new System.Drawing.Point(39, 75);
            this.lblUserNLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNLogin.Name = "lblUserNLogin";
            this.lblUserNLogin.Size = new System.Drawing.Size(87, 29);
            this.lblUserNLogin.TabIndex = 13;
            this.lblUserNLogin.Text = "Username:";
            this.lblUserNLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAccountHeader
            // 
            this.lblAccountHeader.AutoSize = true;
            this.lblAccountHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAccountHeader.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHeader.Location = new System.Drawing.Point(36, 21);
            this.lblAccountHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountHeader.Name = "lblAccountHeader";
            this.lblAccountHeader.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAccountHeader.Size = new System.Drawing.Size(232, 44);
            this.lblAccountHeader.TabIndex = 12;
            this.lblAccountHeader.Text = "Existing Account Login";
            this.lblAccountHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRegistrationLabel
            // 
            this.lblRegistrationLabel.AutoSize = true;
            this.lblRegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrationLabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationLabel.Location = new System.Drawing.Point(111, 212);
            this.lblRegistrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationLabel.Name = "lblRegistrationLabel";
            this.lblRegistrationLabel.Size = new System.Drawing.Size(79, 21);
            this.lblRegistrationLabel.TabIndex = 37;
            this.lblRegistrationLabel.Text = "Register New";
            this.lblRegistrationLabel.Click += new System.EventHandler(this.lblRegistrationLabel_Click);
            // 
            // lblGuestlogin
            // 
            this.lblGuestlogin.AutoSize = true;
            this.lblGuestlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGuestlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestlogin.Location = new System.Drawing.Point(112, 233);
            this.lblGuestlogin.Name = "lblGuestlogin";
            this.lblGuestlogin.Size = new System.Drawing.Size(78, 13);
            this.lblGuestlogin.TabIndex = 38;
            this.lblGuestlogin.Text = "Login as Guest";
            this.lblGuestlogin.Click += new System.EventHandler(this.lblGuestlogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnActLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 333);
            this.Controls.Add(this.lblGuestlogin);
            this.Controls.Add(this.lblRegistrationLabel);
            this.Controls.Add(this.chkShowPasswordLogin);
            this.Controls.Add(this.btnClearActLogin);
            this.Controls.Add(this.btnActLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.lblUserPwLogin);
            this.Controls.Add(this.lblUserNLogin);
            this.Controls.Add(this.lblAccountHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowPasswordLogin;
        private System.Windows.Forms.Button btnClearActLogin;
        private System.Windows.Forms.Button btnActLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Label lblUserPwLogin;
        private System.Windows.Forms.Label lblUserNLogin;
        private System.Windows.Forms.Label lblAccountHeader;
        private System.Windows.Forms.Label lblRegistrationLabel;
        private System.Windows.Forms.Label lblGuestlogin;
    }
}