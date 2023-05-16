namespace ROV_TL.Forms.Additional
{
    partial class PayForm
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
            this.PayButton = new System.Windows.Forms.Button();
            this.StaticVioLabel = new System.Windows.Forms.Label();
            this.ViolationLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.StaticSumLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.Tan;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayButton.ForeColor = System.Drawing.Color.Black;
            this.PayButton.Location = new System.Drawing.Point(310, 387);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(214, 64);
            this.PayButton.TabIndex = 1;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // StaticVioLabel
            // 
            this.StaticVioLabel.AutoSize = true;
            this.StaticVioLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaticVioLabel.ForeColor = System.Drawing.Color.White;
            this.StaticVioLabel.Location = new System.Drawing.Point(60, 91);
            this.StaticVioLabel.Name = "StaticVioLabel";
            this.StaticVioLabel.Size = new System.Drawing.Size(160, 39);
            this.StaticVioLabel.TabIndex = 2;
            this.StaticVioLabel.Text = "Нарушение";
            // 
            // ViolationLabel
            // 
            this.ViolationLabel.AutoSize = true;
            this.ViolationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViolationLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViolationLabel.Location = new System.Drawing.Point(48, 147);
            this.ViolationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ViolationLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ViolationLabel.MinimumSize = new System.Drawing.Size(185, 46);
            this.ViolationLabel.Name = "ViolationLabel";
            this.ViolationLabel.Size = new System.Drawing.Size(191, 75);
            this.ViolationLabel.TabIndex = 23;
            this.ViolationLabel.Text = "VIO TEXT VIO TEXT VIO TEXT VIO TEXT  VIO TEXT ";
            this.ViolationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModelLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(48, 308);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModelLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ModelLabel.MinimumSize = new System.Drawing.Size(185, 46);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(185, 46);
            this.ModelLabel.TabIndex = 25;
            this.ModelLabel.Text = "Car model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "Автомобиль";
            // 
            // PlateLabel
            // 
            this.PlateLabel.AutoSize = true;
            this.PlateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlateLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlateLabel.Location = new System.Drawing.Point(323, 308);
            this.PlateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.PlateLabel.MinimumSize = new System.Drawing.Size(185, 46);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(185, 46);
            this.PlateLabel.TabIndex = 27;
            this.PlateLabel.Text = "NUMPLATE";
            this.PlateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 39);
            this.label4.TabIndex = 26;
            this.label4.Text = "Номерной знак";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumLabel.Location = new System.Drawing.Point(323, 158);
            this.SumLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SumLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.SumLabel.MinimumSize = new System.Drawing.Size(185, 46);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(185, 46);
            this.SumLabel.TabIndex = 29;
            this.SumLabel.Text = "0";
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaticSumLabel
            // 
            this.StaticSumLabel.AutoSize = true;
            this.StaticSumLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaticSumLabel.ForeColor = System.Drawing.Color.White;
            this.StaticSumLabel.Location = new System.Drawing.Point(367, 91);
            this.StaticSumLabel.Name = "StaticSumLabel";
            this.StaticSumLabel.Size = new System.Drawing.Size(97, 39);
            this.StaticSumLabel.TabIndex = 28;
            this.StaticSumLabel.Text = "Сумма";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(41, 387);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(198, 64);
            this.CancelButton.TabIndex = 30;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(12, 18);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(227, 39);
            this.CurrentBalanceLabel.TabIndex = 31;
            this.CurrentBalanceLabel.Text = "Текущий баланс:";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(513, 18);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 39);
            this.CloseButton.TabIndex = 32;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel8.Location = new System.Drawing.Point(-18, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(643, 10);
            this.panel8.TabIndex = 47;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(560, 487);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.StaticSumLabel);
            this.Controls.Add(this.PlateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViolationLabel);
            this.Controls.Add(this.StaticVioLabel);
            this.Controls.Add(this.PayButton);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PayButton;
        private Label StaticVioLabel;
        private Label ViolationLabel;
        private Label ModelLabel;
        private Label label2;
        private Label PlateLabel;
        private Label label4;
        private Label SumLabel;
        private Label StaticSumLabel;
        private Button CancelButton;
        private Label CurrentBalanceLabel;
        private Label CloseButton;
        private Panel panel8;
    }
}