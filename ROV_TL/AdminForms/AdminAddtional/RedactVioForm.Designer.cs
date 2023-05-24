namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class RedactVioForm
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
            this.PlateTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.VioTextBox = new System.Windows.Forms.TextBox();
            this.StaticCloseLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmDataButton = new System.Windows.Forms.Button();
            this.staticRedactLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // PlateTextBox
            // 
            this.PlateTextBox.BackColor = System.Drawing.Color.Tan;
            this.PlateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlateTextBox.Location = new System.Drawing.Point(278, 121);
            this.PlateTextBox.MaxLength = 20;
            this.PlateTextBox.Name = "PlateTextBox";
            this.PlateTextBox.PlaceholderText = "Plate";
            this.PlateTextBox.Size = new System.Drawing.Size(220, 29);
            this.PlateTextBox.TabIndex = 43;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Tan;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Location = new System.Drawing.Point(42, 121);
            this.LoginTextBox.MaxLength = 50;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Login";
            this.LoginTextBox.Size = new System.Drawing.Size(197, 29);
            this.LoginTextBox.TabIndex = 42;
            // 
            // VioTextBox
            // 
            this.VioTextBox.BackColor = System.Drawing.Color.Tan;
            this.VioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VioTextBox.Location = new System.Drawing.Point(42, 75);
            this.VioTextBox.MaxLength = 50;
            this.VioTextBox.Name = "VioTextBox";
            this.VioTextBox.PlaceholderText = "VioText";
            this.VioTextBox.Size = new System.Drawing.Size(456, 29);
            this.VioTextBox.TabIndex = 41;
            // 
            // StaticCloseLabel
            // 
            this.StaticCloseLabel.AutoSize = true;
            this.StaticCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaticCloseLabel.Location = new System.Drawing.Point(516, 15);
            this.StaticCloseLabel.Name = "StaticCloseLabel";
            this.StaticCloseLabel.Size = new System.Drawing.Size(25, 29);
            this.StaticCloseLabel.TabIndex = 40;
            this.StaticCloseLabel.Text = "X";
            this.StaticCloseLabel.Click += new System.EventHandler(this.StaticCloseLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(42, 263);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 34);
            this.CancelButton.TabIndex = 39;
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
            this.ConfirmDataButton.Location = new System.Drawing.Point(278, 263);
            this.ConfirmDataButton.Name = "ConfirmDataButton";
            this.ConfirmDataButton.Size = new System.Drawing.Size(220, 34);
            this.ConfirmDataButton.TabIndex = 38;
            this.ConfirmDataButton.Text = "Подтвердить данные";
            this.ConfirmDataButton.UseVisualStyleBackColor = false;
            this.ConfirmDataButton.Click += new System.EventHandler(this.ConfirmDataButton_Click);
            // 
            // staticRedactLabel
            // 
            this.staticRedactLabel.AutoSize = true;
            this.staticRedactLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticRedactLabel.Location = new System.Drawing.Point(56, 15);
            this.staticRedactLabel.Name = "staticRedactLabel";
            this.staticRedactLabel.Size = new System.Drawing.Size(436, 39);
            this.staticRedactLabel.TabIndex = 37;
            this.staticRedactLabel.Text = "Изменение информации штрафа";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.Tan;
            this.ModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelTextBox.Location = new System.Drawing.Point(42, 166);
            this.ModelTextBox.MaxLength = 50;
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.PlaceholderText = "Model";
            this.ModelTextBox.Size = new System.Drawing.Size(456, 29);
            this.ModelTextBox.TabIndex = 44;
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.Tan;
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Location = new System.Drawing.Point(42, 210);
            this.SumTextBox.MaxLength = 50;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.PlaceholderText = "Sum";
            this.SumTextBox.Size = new System.Drawing.Size(197, 29);
            this.SumTextBox.TabIndex = 45;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(278, 210);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(220, 36);
            this.DateTimePicker.TabIndex = 46;
            // 
            // RedactVioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.PlateTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.VioTextBox);
            this.Controls.Add(this.StaticCloseLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmDataButton);
            this.Controls.Add(this.staticRedactLabel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RedactVioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedactVioForm";
            this.Load += new System.EventHandler(this.RedactVioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PlateTextBox;
        private TextBox LoginTextBox;
        private TextBox VioTextBox;
        private Label StaticCloseLabel;
        private Button CancelButton;
        private Button ConfirmDataButton;
        private Label staticRedactLabel;
        private TextBox ModelTextBox;
        private TextBox SumTextBox;
        private DateTimePicker DateTimePicker;
    }
}