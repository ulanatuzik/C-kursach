namespace ROV_TL.Forms.Additional
{
    partial class RedactCarForm
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
            this.CarModelTextBox = new System.Windows.Forms.TextBox();
            this.staticRedactLabel = new System.Windows.Forms.Label();
            this.ConfirmDataButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StaticCloseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarModelTextBox
            // 
            this.CarModelTextBox.BackColor = System.Drawing.Color.Tan;
            this.CarModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarModelTextBox.Location = new System.Drawing.Point(66, 92);
            this.CarModelTextBox.MaxLength = 20;
            this.CarModelTextBox.Name = "CarModelTextBox";
            this.CarModelTextBox.PlaceholderText = "Car model";
            this.CarModelTextBox.Size = new System.Drawing.Size(414, 29);
            this.CarModelTextBox.TabIndex = 0;
            // 
            // staticRedactLabel
            // 
            this.staticRedactLabel.AutoSize = true;
            this.staticRedactLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticRedactLabel.Location = new System.Drawing.Point(59, 28);
            this.staticRedactLabel.Name = "staticRedactLabel";
            this.staticRedactLabel.Size = new System.Drawing.Size(432, 39);
            this.staticRedactLabel.TabIndex = 1;
            this.staticRedactLabel.Text = "Изменение информации об авто";
            // 
            // ConfirmDataButton
            // 
            this.ConfirmDataButton.BackColor = System.Drawing.Color.Tan;
            this.ConfirmDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmDataButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmDataButton.ForeColor = System.Drawing.Color.Black;
            this.ConfirmDataButton.Location = new System.Drawing.Point(283, 155);
            this.ConfirmDataButton.Name = "ConfirmDataButton";
            this.ConfirmDataButton.Size = new System.Drawing.Size(197, 34);
            this.ConfirmDataButton.TabIndex = 19;
            this.ConfirmDataButton.Text = "Подтвердить данные";
            this.ConfirmDataButton.UseVisualStyleBackColor = false;
            this.ConfirmDataButton.Click += new System.EventHandler(this.ConfirmDataButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(66, 155);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 34);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StaticCloseLabel
            // 
            this.StaticCloseLabel.AutoSize = true;
            this.StaticCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaticCloseLabel.Location = new System.Drawing.Point(510, 9);
            this.StaticCloseLabel.Name = "StaticCloseLabel";
            this.StaticCloseLabel.Size = new System.Drawing.Size(25, 29);
            this.StaticCloseLabel.TabIndex = 21;
            this.StaticCloseLabel.Text = "X";
            this.StaticCloseLabel.Click += new System.EventHandler(this.StaticCloseLabel_Click);
            // 
            // RedactCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(553, 221);
            this.Controls.Add(this.StaticCloseLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmDataButton);
            this.Controls.Add(this.staticRedactLabel);
            this.Controls.Add(this.CarModelTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RedactCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedactCarForm";
            this.Load += new System.EventHandler(this.RedactCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CarModelTextBox;
        private Label staticRedactLabel;
        private Button ConfirmDataButton;
        private Button CancelButton;
        private Label StaticCloseLabel;
    }
}