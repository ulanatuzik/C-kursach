namespace ROV_TL.Forms.Additional
{
    partial class AddCarForm
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
            this.StaticCloseLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.staticRedactLabel = new System.Windows.Forms.Label();
            this.CarModelTextBox = new System.Windows.Forms.TextBox();
            this.NumplateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StaticCloseLabel
            // 
            this.StaticCloseLabel.AutoSize = true;
            this.StaticCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaticCloseLabel.Location = new System.Drawing.Point(507, 9);
            this.StaticCloseLabel.Name = "StaticCloseLabel";
            this.StaticCloseLabel.Size = new System.Drawing.Size(25, 29);
            this.StaticCloseLabel.TabIndex = 26;
            this.StaticCloseLabel.Text = "X";
            this.StaticCloseLabel.Click += new System.EventHandler(this.StaticCloseLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(53, 215);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 34);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.Color.Tan;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCarButton.ForeColor = System.Drawing.Color.Black;
            this.AddCarButton.Location = new System.Drawing.Point(270, 215);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(197, 34);
            this.AddCarButton.TabIndex = 24;
            this.AddCarButton.Text = "Добавить авто";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // staticRedactLabel
            // 
            this.staticRedactLabel.AutoSize = true;
            this.staticRedactLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticRedactLabel.Location = new System.Drawing.Point(53, 25);
            this.staticRedactLabel.Name = "staticRedactLabel";
            this.staticRedactLabel.Size = new System.Drawing.Size(425, 39);
            this.staticRedactLabel.TabIndex = 23;
            this.staticRedactLabel.Text = "Добавление нового автомобиля";
            // 
            // CarModelTextBox
            // 
            this.CarModelTextBox.BackColor = System.Drawing.Color.Tan;
            this.CarModelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarModelTextBox.Location = new System.Drawing.Point(53, 112);
            this.CarModelTextBox.MaxLength = 20;
            this.CarModelTextBox.Name = "CarModelTextBox";
            this.CarModelTextBox.PlaceholderText = "Car model";
            this.CarModelTextBox.Size = new System.Drawing.Size(414, 29);
            this.CarModelTextBox.TabIndex = 22;
            // 
            // NumplateTextBox
            // 
            this.NumplateTextBox.BackColor = System.Drawing.Color.Tan;
            this.NumplateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumplateTextBox.Location = new System.Drawing.Point(53, 162);
            this.NumplateTextBox.MaxLength = 20;
            this.NumplateTextBox.Name = "NumplateTextBox";
            this.NumplateTextBox.PlaceholderText = "Numplate";
            this.NumplateTextBox.Size = new System.Drawing.Size(414, 29);
            this.NumplateTextBox.TabIndex = 27;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(544, 295);
            this.Controls.Add(this.NumplateTextBox);
            this.Controls.Add(this.StaticCloseLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.staticRedactLabel);
            this.Controls.Add(this.CarModelTextBox);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StaticCloseLabel;
        private Button CancelButton;
        private Button AddCarButton;
        private Label staticRedactLabel;
        private TextBox CarModelTextBox;
        private TextBox NumplateTextBox;
    }
}