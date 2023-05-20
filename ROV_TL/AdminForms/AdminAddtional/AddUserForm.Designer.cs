namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class AddUserForm
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
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.StaticCloseLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmDataButton = new System.Windows.Forms.Button();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.staticRedactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.BackColor = System.Drawing.Color.Tan;
            this.BalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalanceTextBox.Location = new System.Drawing.Point(39, 136);
            this.BalanceTextBox.MaxLength = 50;
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.PlaceholderText = "Баланс";
            this.BalanceTextBox.Size = new System.Drawing.Size(197, 29);
            this.BalanceTextBox.TabIndex = 46;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Tan;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(275, 81);
            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 29);
            this.PasswordTextBox.TabIndex = 45;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Tan;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Location = new System.Drawing.Point(39, 81);
            this.LoginTextBox.MaxLength = 50;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Login";
            this.LoginTextBox.Size = new System.Drawing.Size(197, 29);
            this.LoginTextBox.TabIndex = 44;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.Tan;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Location = new System.Drawing.Point(275, 136);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(220, 29);
            this.EmailTextBox.TabIndex = 43;
            // 
            // StaticCloseLabel
            // 
            this.StaticCloseLabel.AutoSize = true;
            this.StaticCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaticCloseLabel.Location = new System.Drawing.Point(519, 9);
            this.StaticCloseLabel.Name = "StaticCloseLabel";
            this.StaticCloseLabel.Size = new System.Drawing.Size(25, 29);
            this.StaticCloseLabel.TabIndex = 42;
            this.StaticCloseLabel.Text = "X";
            this.StaticCloseLabel.Click += new System.EventHandler(this.StaticCloseLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(39, 237);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 34);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmDataButton
            // 
            this.ConfirmDataButton.BackColor = System.Drawing.Color.Tan;
            this.ConfirmDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmDataButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmDataButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmDataButton.Location = new System.Drawing.Point(275, 237);
            this.ConfirmDataButton.Name = "ConfirmDataButton";
            this.ConfirmDataButton.Size = new System.Drawing.Size(220, 34);
            this.ConfirmDataButton.TabIndex = 40;
            this.ConfirmDataButton.Text = "Создать пользователя";
            this.ConfirmDataButton.UseVisualStyleBackColor = false;
            this.ConfirmDataButton.Click += new System.EventHandler(this.ConfirmDataButton_Click);
            // 
            // FioTextBox
            // 
            this.FioTextBox.BackColor = System.Drawing.Color.Tan;
            this.FioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FioTextBox.Location = new System.Drawing.Point(39, 182);
            this.FioTextBox.MaxLength = 50;
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.PlaceholderText = "ФИО";
            this.FioTextBox.Size = new System.Drawing.Size(456, 29);
            this.FioTextBox.TabIndex = 39;
            // 
            // staticRedactLabel
            // 
            this.staticRedactLabel.AutoSize = true;
            this.staticRedactLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticRedactLabel.Location = new System.Drawing.Point(35, 23);
            this.staticRedactLabel.Name = "staticRedactLabel";
            this.staticRedactLabel.Size = new System.Drawing.Size(449, 39);
            this.staticRedactLabel.TabIndex = 38;
            this.staticRedactLabel.Text = "Добавление нового пользователя";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.StaticCloseLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmDataButton);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.staticRedactLabel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BalanceTextBox;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private Label StaticCloseLabel;
        private Button CancelButton;
        private Button ConfirmDataButton;
        private TextBox FioTextBox;
        private Label staticRedactLabel;
    }
}