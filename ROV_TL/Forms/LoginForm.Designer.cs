namespace ROV_TL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.StaticLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Tan;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(181, 246);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 46);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Tan;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.Location = new System.Drawing.Point(27, 126);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Логин";
            this.LoginTextBox.Size = new System.Drawing.Size(279, 35);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Tan;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(27, 180);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Пароль";
            this.PasswordTextBox.Size = new System.Drawing.Size(279, 35);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Tan;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(27, 246);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(111, 46);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(288, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(30, 33);
            this.CloseLabel.TabIndex = 8;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // StaticLabel
            // 
            this.StaticLabel.AutoSize = true;
            this.StaticLabel.BackColor = System.Drawing.Color.Tan;
            this.StaticLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaticLabel.Location = new System.Drawing.Point(68, 17);
            this.StaticLabel.Name = "StaticLabel";
            this.StaticLabel.Size = new System.Drawing.Size(191, 42);
            this.StaticLabel.TabIndex = 7;
            this.StaticLabel.Text = "Вход в аккаунт";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Controls.Add(this.StaticLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 75);
            this.panel1.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(329, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Label CloseLabel;
        private Label StaticLabel;
        private Panel panel1;
    }
}