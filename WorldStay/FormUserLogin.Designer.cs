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
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.panelLeftLogo = new System.Windows.Forms.Panel();
            this.panelTopStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.panelLeftLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopStrip
            // 
            this.panelTopStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(183)))), ((int)(((byte)(141)))));
            this.panelTopStrip.Controls.Add(this.panel3);
            this.panelTopStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStrip.Location = new System.Drawing.Point(0, 0);
            this.panelTopStrip.Name = "panelTopStrip";
            this.panelTopStrip.Size = new System.Drawing.Size(2157, 20);
            this.panelTopStrip.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(89, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 132);
            this.panel3.TabIndex = 2;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.Color.White;
            this.buttonCloseForm.Location = new System.Drawing.Point(2099, -1);
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
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2157, 1135);
            this.Controls.Add(this.panelLeftLogo);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.panelTopStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserLogin";
            this.Text = "FormUserLogin";
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            this.panelTopStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.panelLeftLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopStrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Panel panelLeftLogo;
    }
}