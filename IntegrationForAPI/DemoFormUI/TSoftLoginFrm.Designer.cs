
namespace DemoFormUI
{
    partial class TSoftLoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TSoftLoginFrm));
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPasswd = new System.Windows.Forms.TextBox();
            this.lblWebs = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.epUserNamePasswdNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorUserName = new System.Windows.Forms.Label();
            this.lblErrorPasswd = new System.Windows.Forms.Label();
            this.epUserNameOrPasswdWrong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epUserNamePasswdNull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserNameOrPasswdWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(123, 32);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(125, 27);
            this.tbxUserName.TabIndex = 0;
            // 
            // tbxPasswd
            // 
            this.tbxPasswd.Location = new System.Drawing.Point(123, 94);
            this.tbxPasswd.Name = "tbxPasswd";
            this.tbxPasswd.PasswordChar = '*';
            this.tbxPasswd.Size = new System.Drawing.Size(125, 27);
            this.tbxPasswd.TabIndex = 1;
            // 
            // lblWebs
            // 
            this.lblWebs.AutoSize = true;
            this.lblWebs.Location = new System.Drawing.Point(141, 9);
            this.lblWebs.Name = "lblWebs";
            this.lblWebs.Size = new System.Drawing.Size(94, 20);
            this.lblWebs.TabIndex = 2;
            this.lblWebs.Text = "Web Service ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Kullanıcı Adı :";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(71, 97);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(46, 20);
            this.lblPasswd.TabIndex = 2;
            this.lblPasswd.Text = "Şifre :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(141, 145);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // epUserNamePasswdNull
            // 
            this.epUserNamePasswdNull.ContainerControl = this;
            this.epUserNamePasswdNull.Icon = ((System.Drawing.Icon)(resources.GetObject("epUserNamePasswdNull.Icon")));
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.Location = new System.Drawing.Point(123, 60);
            this.lblErrorUserName.Name = "lblErrorUserName";
            this.lblErrorUserName.Size = new System.Drawing.Size(13, 20);
            this.lblErrorUserName.TabIndex = 4;
            this.lblErrorUserName.Text = " ";
            // 
            // lblErrorPasswd
            // 
            this.lblErrorPasswd.AutoSize = true;
            this.lblErrorPasswd.Location = new System.Drawing.Point(123, 121);
            this.lblErrorPasswd.Name = "lblErrorPasswd";
            this.lblErrorPasswd.Size = new System.Drawing.Size(13, 20);
            this.lblErrorPasswd.TabIndex = 4;
            this.lblErrorPasswd.Text = " ";
            // 
            // epUserNameOrPasswdWrong
            // 
            this.epUserNameOrPasswdWrong.ContainerControl = this;
            this.epUserNameOrPasswdWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epUserNameOrPasswdWrong.Icon")));
            // 
            // TSoftLoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.lblErrorPasswd);
            this.Controls.Add(this.lblErrorUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWebs);
            this.Controls.Add(this.tbxPasswd);
            this.Controls.Add(this.tbxUserName);
            this.Name = "TSoftLoginFrm";
            this.Text = "T-Soft Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TSoftLoginFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.epUserNamePasswdNull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserNameOrPasswdWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPasswd;
        private System.Windows.Forms.Label lblWebs;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider epUserNamePasswdNull;
        private System.Windows.Forms.Label lblErrorPasswd;
        private System.Windows.Forms.Label lblErrorUserName;
        private System.Windows.Forms.ErrorProvider epUserNameOrPasswdWrong;
    }
}