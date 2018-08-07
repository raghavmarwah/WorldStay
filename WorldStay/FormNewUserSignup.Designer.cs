namespace WorldStay
{
    partial class FormNewUserSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUserSignup));
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.panelTopStrip = new System.Windows.Forms.Panel();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.panelLeftLogo = new System.Windows.Forms.Panel();
            this.labelInfoDisplay = new System.Windows.Forms.Label();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUserSignupInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.panelLeftLogo.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonCloseForm.TabIndex = 19;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // panelTopStrip
            // 
            this.panelTopStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.panelTopStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStrip.Location = new System.Drawing.Point(0, 0);
            this.panelTopStrip.Name = "panelTopStrip";
            this.panelTopStrip.Size = new System.Drawing.Size(1603, 20);
            this.panelTopStrip.TabIndex = 18;
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
            this.panelLeftLogo.Location = new System.Drawing.Point(0, 20);
            this.panelLeftLogo.Name = "panelLeftLogo";
            this.panelLeftLogo.Size = new System.Drawing.Size(384, 1115);
            this.panelLeftLogo.TabIndex = 20;
            // 
            // labelInfoDisplay
            // 
            this.labelInfoDisplay.AutoSize = true;
            this.labelInfoDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoDisplay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInfoDisplay.Location = new System.Drawing.Point(782, 882);
            this.labelInfoDisplay.Name = "labelInfoDisplay";
            this.labelInfoDisplay.Size = new System.Drawing.Size(379, 45);
            this.labelInfoDisplay.TabIndex = 32;
            this.labelInfoDisplay.Text = "Username already exists!";
            this.labelInfoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfoDisplay.Visible = false;
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.buttonClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearForm.ForeColor = System.Drawing.Color.White;
            this.buttonClearForm.Location = new System.Drawing.Point(997, 754);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(280, 66);
            this.buttonClearForm.TabIndex = 26;
            this.buttonClearForm.Text = "Clear Form";
            this.buttonClearForm.UseVisualStyleBackColor = false;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.Location = new System.Drawing.Point(672, 754);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(280, 66);
            this.buttonCreateAccount.TabIndex = 25;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassword.Location = new System.Drawing.Point(601, 600);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(211, 59);
            this.labelPassword.TabIndex = 31;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsername.Location = new System.Drawing.Point(601, 513);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(224, 59);
            this.labelUsername.TabIndex = 30;
            this.labelUsername.Text = "Username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsTab = true;
            this.textBoxPassword.BackColor = System.Drawing.Color.Silver;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(845, 600);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(486, 58);
            this.textBoxPassword.TabIndex = 24;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AcceptsTab = true;
            this.textBoxUsername.BackColor = System.Drawing.Color.Silver;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(845, 513);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(486, 58);
            this.textBoxUsername.TabIndex = 23;
            // 
            // labelUserSignupInfo
            // 
            this.labelUserSignupInfo.AutoSize = true;
            this.labelUserSignupInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserSignupInfo.Font = new System.Drawing.Font("Segoe UI", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSignupInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserSignupInfo.Location = new System.Drawing.Point(599, 373);
            this.labelUserSignupInfo.Name = "labelUserSignupInfo";
            this.labelUserSignupInfo.Size = new System.Drawing.Size(326, 71);
            this.labelUserSignupInfo.TabIndex = 27;
            this.labelUserSignupInfo.Text = "User Signup";
            this.labelUserSignupInfo.UseMnemonic = false;
            // 
            // FormNewUserSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 1135);
            this.Controls.Add(this.labelInfoDisplay);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUserSignupInfo);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panelTopStrip);
            this.Controls.Add(this.panelLeftLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewUserSignup";
            this.Text = "FormNewUserSignup";
            this.Load += new System.EventHandler(this.FormNewUserSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.panelLeftLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Panel panelTopStrip;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Panel panelLeftLogo;
        private System.Windows.Forms.Label labelInfoDisplay;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUserSignupInfo;
    }
}