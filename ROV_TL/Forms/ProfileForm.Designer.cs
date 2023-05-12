namespace ROV_TL
{
    partial class ProfileForm
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
            this.vioLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.fioLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.carInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vioLabel
            // 
            this.vioLabel.AutoSize = true;
            this.vioLabel.Location = new System.Drawing.Point(28, 58);
            this.vioLabel.Name = "vioLabel";
            this.vioLabel.Size = new System.Drawing.Size(54, 15);
            this.vioLabel.TabIndex = 3;
            this.vioLabel.Text = "Штрафы";
            this.vioLabel.Click += new System.EventHandler(this.vioLabel_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(27, 29);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(59, 15);
            this.profileLabel.TabIndex = 2;
            this.profileLabel.Text = "Профиль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(174, 29);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(34, 15);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "login";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(337, 29);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(21, 15);
            this.fioLabel.TabIndex = 5;
            this.fioLabel.Text = "fio";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(253, 29);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "email";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(453, 29);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(48, 15);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "balance";
            // 
            // carInfoLabel
            // 
            this.carInfoLabel.AutoSize = true;
            this.carInfoLabel.Location = new System.Drawing.Point(174, 92);
            this.carInfoLabel.Name = "carInfoLabel";
            this.carInfoLabel.Size = new System.Drawing.Size(118, 15);
            this.carInfoLabel.TabIndex = 8;
            this.carInfoLabel.Text = "Информация о авто";
            this.carInfoLabel.Click += new System.EventHandler(this.carInfoLabel_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carInfoLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.vioLabel);
            this.Controls.Add(this.profileLabel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label vioLabel;
        private Label profileLabel;
        private Label loginLabel;
        private Label fioLabel;
        private Label emailLabel;
        private Label balanceLabel;
        private Label carInfoLabel;
    }
}