namespace WorldStay
{
    partial class FormUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLogin));
            this.panelTopStrip = new System.Windows.Forms.Panel();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.panelLeftLogo = new System.Windows.Forms.Panel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserLoginInfo = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.panelLeftLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopStrip
            // 
            this.panelTopStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.panelTopStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStrip.Location = new System.Drawing.Point(0, 0);
            this.panelTopStrip.Name = "panelTopStrip";
            this.panelTopStrip.Size = new System.Drawing.Size(1603, 20);
            this.panelTopStrip.TabIndex = 6;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.Color.White;
            this.buttonCloseForm.Location = new System.Drawing.Point(1545, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(58, 52);
            this.buttonCloseForm.TabIndex = 8;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.Image")));
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(0, 353);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(389, 382);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainLogo.TabIndex = 9;
            this.pictureBoxMainLogo.TabStop = false;
            // 
            // panelLeftLogo
            // 
            this.panelLeftLogo.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeftLogo.Controls.Add(this.pictureBoxMainLogo);
            this.panelLeftLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftLogo.Location = new System.Drawing.Point(0, 20);
            this.panelLeftLogo.Name = "panelLeftLogo";
            this.panelLeftLogo.Size = new System.Drawing.Size(384, 1115);
            this.panelLeftLogo.TabIndex = 10;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(1029, 741);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(181, 66);
            this.buttonSignUp.TabIndex = 17;
            this.buttonSignUp.Text = "SignUp";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(765, 741);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(181, 66);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "LogIn";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassword.Location = new System.Drawing.Point(601, 597);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(211, 59);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsername.Location = new System.Drawing.Point(601, 499);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(224, 59);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserLoginInfo
            // 
            this.labelUserLoginInfo.AutoSize = true;
            this.labelUserLoginInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserLoginInfo.Font = new System.Drawing.Font("Segoe UI", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLoginInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserLoginInfo.Location = new System.Drawing.Point(599, 373);
            this.labelUserLoginInfo.Name = "labelUserLoginInfo";
            this.labelUserLoginInfo.Size = new System.Drawing.Size(292, 71);
            this.labelUserLoginInfo.TabIndex = 14;
            this.labelUserLoginInfo.Text = "User Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsTab = true;
            this.textBoxPassword.BackColor = System.Drawing.Color.Silver;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(835, 597);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(486, 58);
            this.textBoxPassword.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AcceptsTab = true;
            this.textBoxUsername.BackColor = System.Drawing.Color.Silver;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(835, 499);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(486, 58);
            this.textBoxUsername.TabIndex = 12;
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 1135);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserLoginInfo);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.panelLeftLogo);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panelTopStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserLogin";
            this.Text = "FormUserLogin";
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.panelLeftLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTopStrip;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Panel panelLeftLogo;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserLoginInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}