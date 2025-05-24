namespace CarDealership
{
    partial class frmRegistration
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
            this.lblRegistrationLink = new System.Windows.Forms.Label();
            this.btnClearActLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserPwCnfLogin = new System.Windows.Forms.Label();
            this.lblUserPwLogin = new System.Windows.Forms.Label();
            this.lblUserNLogin = new System.Windows.Forms.Label();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkShowPasswordLogin
            // 
            this.chkShowPasswordLogin.AutoSize = true;
            this.chkShowPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkShowPasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPasswordLogin.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPasswordLogin.Location = new System.Drawing.Point(155, 232);
            this.chkShowPasswordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPasswordLogin.Name = "chkShowPasswordLogin";
            this.chkShowPasswordLogin.Size = new System.Drawing.Size(109, 24);
            this.chkShowPasswordLogin.TabIndex = 35;
            this.chkShowPasswordLogin.Text = "Show Password";
            this.chkShowPasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowPasswordLogin.UseVisualStyleBackColor = false;
            this.chkShowPasswordLogin.CheckedChanged += new System.EventHandler(this.chkShowPasswordLogin_CheckedChanged);
            // 
            // lblRegistrationLink
            // 
            this.lblRegistrationLink.AutoSize = true;
            this.lblRegistrationLink.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegistrationLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistrationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrationLink.Font = new System.Drawing.Font("Myanmar Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRegistrationLink.Location = new System.Drawing.Point(63, 366);
            this.lblRegistrationLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationLink.Name = "lblRegistrationLink";
            this.lblRegistrationLink.Size = new System.Drawing.Size(158, 26);
            this.lblRegistrationLink.TabIndex = 34;
            this.lblRegistrationLink.Text = "Return to account login";
            this.lblRegistrationLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRegistrationLink.Click += new System.EventHandler(this.lblRegistrationLink_Click);
            // 
            // btnClearActLogin
            // 
            this.btnClearActLogin.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.btnClearActLogin.Location = new System.Drawing.Point(60, 320);
            this.btnClearActLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearActLogin.Name = "btnClearActLogin";
            this.btnClearActLogin.Size = new System.Drawing.Size(170, 27);
            this.btnClearActLogin.TabIndex = 33;
            this.btnClearActLogin.Text = "Clear";
            this.btnClearActLogin.UseVisualStyleBackColor = true;
            this.btnClearActLogin.Click += new System.EventHandler(this.btnClearActLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegister.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.btnRegister.Location = new System.Drawing.Point(60, 284);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 27);
            this.btnRegister.TabIndex = 32;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(40, 203);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordConfirm.MaxLength = 20;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '⬤';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(224, 20);
            this.txtPasswordConfirm.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 153);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '⬤';
            this.txtPassword.Size = new System.Drawing.Size(224, 20);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(40, 94);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(224, 20);
            this.txtUserName.TabIndex = 29;
            // 
            // lblUserPwCnfLogin
            // 
            this.lblUserPwCnfLogin.AutoSize = true;
            this.lblUserPwCnfLogin.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.lblUserPwCnfLogin.Location = new System.Drawing.Point(35, 179);
            this.lblUserPwCnfLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPwCnfLogin.Name = "lblUserPwCnfLogin";
            this.lblUserPwCnfLogin.Size = new System.Drawing.Size(144, 29);
            this.lblUserPwCnfLogin.TabIndex = 27;
            this.lblUserPwCnfLogin.Text = "Confirm Password:";
            // 
            // lblUserPwLogin
            // 
            this.lblUserPwLogin.AutoSize = true;
            this.lblUserPwLogin.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.lblUserPwLogin.Location = new System.Drawing.Point(35, 129);
            this.lblUserPwLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPwLogin.Name = "lblUserPwLogin";
            this.lblUserPwLogin.Size = new System.Drawing.Size(83, 29);
            this.lblUserPwLogin.TabIndex = 26;
            this.lblUserPwLogin.Text = "Password:";
            this.lblUserPwLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserNLogin
            // 
            this.lblUserNLogin.AutoSize = true;
            this.lblUserNLogin.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNLogin.Location = new System.Drawing.Point(35, 70);
            this.lblUserNLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNLogin.Name = "lblUserNLogin";
            this.lblUserNLogin.Size = new System.Drawing.Size(87, 29);
            this.lblUserNLogin.TabIndex = 25;
            this.lblUserNLogin.Text = "Username:";
            this.lblUserNLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAccountHeader
            // 
            this.lblAccountHeader.AutoSize = true;
            this.lblAccountHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAccountHeader.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHeader.Location = new System.Drawing.Point(59, 14);
            this.lblAccountHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountHeader.Name = "lblAccountHeader";
            this.lblAccountHeader.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAccountHeader.Size = new System.Drawing.Size(180, 44);
            this.lblAccountHeader.TabIndex = 24;
            this.lblAccountHeader.Text = "Register Account";
            this.lblAccountHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(309, 408);
            this.ControlBox = false;
            this.Controls.Add(this.chkShowPasswordLogin);
            this.Controls.Add(this.lblRegistrationLink);
            this.Controls.Add(this.btnClearActLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserPwCnfLogin);
            this.Controls.Add(this.lblUserPwLogin);
            this.Controls.Add(this.lblUserNLogin);
            this.Controls.Add(this.lblAccountHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowPasswordLogin;
        private System.Windows.Forms.Label lblRegistrationLink;
        private System.Windows.Forms.Button btnClearActLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserPwCnfLogin;
        private System.Windows.Forms.Label lblUserPwLogin;
        private System.Windows.Forms.Label lblUserNLogin;
        private System.Windows.Forms.Label lblAccountHeader;
    }
}