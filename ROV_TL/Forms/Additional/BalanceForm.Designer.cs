namespace ROV_TL.Forms.Additional
{
    partial class BalanceForm
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
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(30, 20);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(227, 39);
            this.CurrentBalanceLabel.TabIndex = 32;
            this.CurrentBalanceLabel.Text = "Текущий баланс:";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(458, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 39);
            this.CloseButton.TabIndex = 33;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SumTextBox
            // 
            this.SumTextBox.BackColor = System.Drawing.Color.Tan;
            this.SumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumTextBox.Location = new System.Drawing.Point(30, 92);
            this.SumTextBox.MaxLength = 20;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.PlaceholderText = "Сумма";
            this.SumTextBox.Size = new System.Drawing.Size(447, 35);
            this.SumTextBox.TabIndex = 34;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(30, 155);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(159, 54);
            this.CancelButton.TabIndex = 36;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.Tan;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayButton.ForeColor = System.Drawing.Color.Black;
            this.PayButton.Location = new System.Drawing.Point(307, 155);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(170, 54);
            this.PayButton.TabIndex = 35;
            this.PayButton.Text = "Пополнить";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(502, 242);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CurrentBalanceLabel;
        private Label CloseButton;
        private TextBox SumTextBox;
        private Button CancelButton;
        private Button PayButton;
    }
}