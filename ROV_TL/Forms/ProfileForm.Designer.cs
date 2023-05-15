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
            this.VioLabel = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.StaticLoginLabel = new System.Windows.Forms.Label();
            this.StaticEmailLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.CarInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ROVLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.StaticFioLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.StaticPasswordLabel = new System.Windows.Forms.Label();
            this.StaticBalanceLabel = new System.Windows.Forms.Label();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.ConfirmDataButton = new System.Windows.Forms.Button();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.UpdatePictureBox = new System.Windows.Forms.PictureBox();
            this.AcessPictureBox_1 = new System.Windows.Forms.PictureBox();
            this.AcessPictureBox_3 = new System.Windows.Forms.PictureBox();
            this.AcessPictureBox_4 = new System.Windows.Forms.PictureBox();
            this.AcessPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_2)).BeginInit();
            this.SuspendLayout();
            // 
            // VioLabel
            // 
            this.VioLabel.AutoSize = true;
            this.VioLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VioLabel.Location = new System.Drawing.Point(11, 139);
            this.VioLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VioLabel.Name = "VioLabel";
            this.VioLabel.Size = new System.Drawing.Size(93, 29);
            this.VioLabel.TabIndex = 3;
            this.VioLabel.Text = "Штрафы";
            this.VioLabel.Click += new System.EventHandler(this.VioLabel_Click);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabel.Location = new System.Drawing.Point(12, 97);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(98, 29);
            this.ProfileLabel.TabIndex = 2;
            this.ProfileLabel.Text = "Профиль";
            // 
            // StaticLoginLabel
            // 
            this.StaticLoginLabel.AutoSize = true;
            this.StaticLoginLabel.ForeColor = System.Drawing.Color.White;
            this.StaticLoginLabel.Location = new System.Drawing.Point(206, 114);
            this.StaticLoginLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StaticLoginLabel.Name = "StaticLoginLabel";
            this.StaticLoginLabel.Size = new System.Drawing.Size(71, 29);
            this.StaticLoginLabel.TabIndex = 4;
            this.StaticLoginLabel.Text = "Логин";
            // 
            // StaticEmailLabel
            // 
            this.StaticEmailLabel.AutoSize = true;
            this.StaticEmailLabel.ForeColor = System.Drawing.Color.White;
            this.StaticEmailLabel.Location = new System.Drawing.Point(206, 213);
            this.StaticEmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StaticEmailLabel.Name = "StaticEmailLabel";
            this.StaticEmailLabel.Size = new System.Drawing.Size(65, 29);
            this.StaticEmailLabel.TabIndex = 6;
            this.StaticEmailLabel.Text = "Email";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.ForeColor = System.Drawing.Color.White;
            this.BalanceLabel.Location = new System.Drawing.Point(386, 36);
            this.BalanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(86, 29);
            this.BalanceLabel.TabIndex = 7;
            this.BalanceLabel.Text = "balance";
            // 
            // CarInfoLabel
            // 
            this.CarInfoLabel.AutoSize = true;
            this.CarInfoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarInfoLabel.Location = new System.Drawing.Point(11, 175);
            this.CarInfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarInfoLabel.Name = "CarInfoLabel";
            this.CarInfoLabel.Size = new System.Drawing.Size(126, 29);
            this.CarInfoLabel.TabIndex = 8;
            this.CarInfoLabel.Text = "Автомобили";
            this.CarInfoLabel.Click += new System.EventHandler(this.CarInfoLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CarInfoLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ROVLabel);
            this.panel1.Controls.Add(this.ProfileLabel);
            this.panel1.Controls.Add(this.VioLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 459);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Location = new System.Drawing.Point(0, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 5);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Location = new System.Drawing.Point(-2, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 10);
            this.panel2.TabIndex = 5;
            // 
            // ROVLabel
            // 
            this.ROVLabel.AutoSize = true;
            this.ROVLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ROVLabel.Location = new System.Drawing.Point(34, 10);
            this.ROVLabel.Name = "ROVLabel";
            this.ROVLabel.Size = new System.Drawing.Size(99, 58);
            this.ROVLabel.TabIndex = 4;
            this.ROVLabel.Text = "ROV";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Tan;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.Location = new System.Drawing.Point(212, 150);
            this.LoginTextBox.MaxLength = 12;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Логин";
            this.LoginTextBox.ReadOnly = true;
            this.LoginTextBox.Size = new System.Drawing.Size(279, 35);
            this.LoginTextBox.TabIndex = 10;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.Tan;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(212, 249);
            this.EmailTextBox.MaxLength = 25;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(279, 35);
            this.EmailTextBox.TabIndex = 11;
            // 
            // FioTextBox
            // 
            this.FioTextBox.BackColor = System.Drawing.Color.Tan;
            this.FioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FioTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FioTextBox.Location = new System.Drawing.Point(547, 249);
            this.FioTextBox.MaxLength = 75;
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.PlaceholderText = "ФИО";
            this.FioTextBox.ReadOnly = true;
            this.FioTextBox.Size = new System.Drawing.Size(279, 35);
            this.FioTextBox.TabIndex = 13;
            // 
            // StaticFioLabel
            // 
            this.StaticFioLabel.AutoSize = true;
            this.StaticFioLabel.ForeColor = System.Drawing.Color.White;
            this.StaticFioLabel.Location = new System.Drawing.Point(541, 213);
            this.StaticFioLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StaticFioLabel.Name = "StaticFioLabel";
            this.StaticFioLabel.Size = new System.Drawing.Size(56, 29);
            this.StaticFioLabel.TabIndex = 12;
            this.StaticFioLabel.Text = "ФИО";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Tan;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(547, 150);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Пароль";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(279, 35);
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // StaticPasswordLabel
            // 
            this.StaticPasswordLabel.AutoSize = true;
            this.StaticPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.StaticPasswordLabel.Location = new System.Drawing.Point(541, 114);
            this.StaticPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StaticPasswordLabel.Name = "StaticPasswordLabel";
            this.StaticPasswordLabel.Size = new System.Drawing.Size(80, 29);
            this.StaticPasswordLabel.TabIndex = 14;
            this.StaticPasswordLabel.Text = "Пароль";
            // 
            // StaticBalanceLabel
            // 
            this.StaticBalanceLabel.AutoSize = true;
            this.StaticBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.StaticBalanceLabel.Location = new System.Drawing.Point(206, 36);
            this.StaticBalanceLabel.Name = "StaticBalanceLabel";
            this.StaticBalanceLabel.Size = new System.Drawing.Size(172, 29);
            this.StaticBalanceLabel.TabIndex = 16;
            this.StaticBalanceLabel.Text = "Текущий баланс:";
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.BackColor = System.Drawing.Color.Tan;
            this.ChangeDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeDataButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeDataButton.Location = new System.Drawing.Point(212, 318);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(279, 34);
            this.ChangeDataButton.TabIndex = 17;
            this.ChangeDataButton.Text = "Изменить профиль";
            this.ChangeDataButton.UseVisualStyleBackColor = false;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // ConfirmDataButton
            // 
            this.ConfirmDataButton.BackColor = System.Drawing.Color.Tan;
            this.ConfirmDataButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ConfirmDataButton.Enabled = false;
            this.ConfirmDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmDataButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmDataButton.Location = new System.Drawing.Point(547, 318);
            this.ConfirmDataButton.Name = "ConfirmDataButton";
            this.ConfirmDataButton.Size = new System.Drawing.Size(279, 34);
            this.ConfirmDataButton.TabIndex = 18;
            this.ConfirmDataButton.Text = "Подтвердить данные";
            this.ConfirmDataButton.UseVisualStyleBackColor = false;
            this.ConfirmDataButton.Click += new System.EventHandler(this.ConfirmDataButton_Click);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPictureBox.Image = global::ROV_TL.Properties.Resources.ExitIcon;
            this.ExitPictureBox.Location = new System.Drawing.Point(816, 12);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(39, 35);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 19;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // UpdatePictureBox
            // 
            this.UpdatePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatePictureBox.Image = global::ROV_TL.Properties.Resources.UpdateIcon2;
            this.UpdatePictureBox.Location = new System.Drawing.Point(771, 12);
            this.UpdatePictureBox.Name = "UpdatePictureBox";
            this.UpdatePictureBox.Size = new System.Drawing.Size(39, 35);
            this.UpdatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdatePictureBox.TabIndex = 20;
            this.UpdatePictureBox.TabStop = false;
            this.UpdatePictureBox.Click += new System.EventHandler(this.UpdatePictureBox_Click);
            // 
            // AcessPictureBox_1
            // 
            this.AcessPictureBox_1.BackColor = System.Drawing.Color.Tan;
            this.AcessPictureBox_1.Image = global::ROV_TL.Properties.Resources.LockIcon;
            this.AcessPictureBox_1.Location = new System.Drawing.Point(457, 152);
            this.AcessPictureBox_1.Name = "AcessPictureBox_1";
            this.AcessPictureBox_1.Size = new System.Drawing.Size(25, 31);
            this.AcessPictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcessPictureBox_1.TabIndex = 21;
            this.AcessPictureBox_1.TabStop = false;
            // 
            // AcessPictureBox_3
            // 
            this.AcessPictureBox_3.BackColor = System.Drawing.Color.Tan;
            this.AcessPictureBox_3.Image = global::ROV_TL.Properties.Resources.LockIcon;
            this.AcessPictureBox_3.Location = new System.Drawing.Point(457, 251);
            this.AcessPictureBox_3.Name = "AcessPictureBox_3";
            this.AcessPictureBox_3.Size = new System.Drawing.Size(25, 31);
            this.AcessPictureBox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcessPictureBox_3.TabIndex = 22;
            this.AcessPictureBox_3.TabStop = false;
            // 
            // AcessPictureBox_4
            // 
            this.AcessPictureBox_4.BackColor = System.Drawing.Color.Tan;
            this.AcessPictureBox_4.Image = global::ROV_TL.Properties.Resources.LockIcon;
            this.AcessPictureBox_4.Location = new System.Drawing.Point(791, 251);
            this.AcessPictureBox_4.Name = "AcessPictureBox_4";
            this.AcessPictureBox_4.Size = new System.Drawing.Size(25, 31);
            this.AcessPictureBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcessPictureBox_4.TabIndex = 24;
            this.AcessPictureBox_4.TabStop = false;
            // 
            // AcessPictureBox_2
            // 
            this.AcessPictureBox_2.BackColor = System.Drawing.Color.Tan;
            this.AcessPictureBox_2.Image = global::ROV_TL.Properties.Resources.LockIcon;
            this.AcessPictureBox_2.Location = new System.Drawing.Point(791, 152);
            this.AcessPictureBox_2.Name = "AcessPictureBox_2";
            this.AcessPictureBox_2.Size = new System.Drawing.Size(25, 31);
            this.AcessPictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcessPictureBox_2.TabIndex = 23;
            this.AcessPictureBox_2.TabStop = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(867, 455);
            this.Controls.Add(this.AcessPictureBox_4);
            this.Controls.Add(this.AcessPictureBox_2);
            this.Controls.Add(this.AcessPictureBox_3);
            this.Controls.Add(this.AcessPictureBox_1);
            this.Controls.Add(this.UpdatePictureBox);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.ConfirmDataButton);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.StaticBalanceLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.StaticPasswordLabel);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.StaticFioLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.StaticEmailLabel);
            this.Controls.Add(this.StaticLoginLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcessPictureBox_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VioLabel;
        private Label ProfileLabel;
        private Label StaticLoginLabel;
        private Label StaticEmailLabel;
        private Label BalanceLabel;
        private Label CarInfoLabel;
        private Panel panel1;
        private Panel panel2;
        private Label ROVLabel;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private TextBox FioTextBox;
        private Label StaticFioLabel;
        private TextBox PasswordTextBox;
        private Label StaticPasswordLabel;
        private Label StaticBalanceLabel;
        private Button ChangeDataButton;
        private Button ConfirmDataButton;
        private PictureBox ExitPictureBox;
        private Panel panel3;
        private PictureBox UpdatePictureBox;
        private PictureBox AcessPictureBox_1;
        private PictureBox AcessPictureBox_3;
        private PictureBox AcessPictureBox_4;
        private PictureBox AcessPictureBox_2;
    }
}