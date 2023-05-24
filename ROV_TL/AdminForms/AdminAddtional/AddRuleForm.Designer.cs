namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class AddRuleForm
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
            this.FineTextBox = new System.Windows.Forms.TextBox();
            this.RuleTextBox = new System.Windows.Forms.TextBox();
            this.StaticCloseLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmDataButton = new System.Windows.Forms.Button();
            this.staticRedactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FineTextBox
            // 
            this.FineTextBox.BackColor = System.Drawing.Color.Tan;
            this.FineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FineTextBox.Location = new System.Drawing.Point(38, 184);
            this.FineTextBox.MaxLength = 20;
            this.FineTextBox.Name = "FineTextBox";
            this.FineTextBox.PlaceholderText = "Fine";
            this.FineTextBox.Size = new System.Drawing.Size(456, 29);
            this.FineTextBox.TabIndex = 50;
            // 
            // RuleTextBox
            // 
            this.RuleTextBox.BackColor = System.Drawing.Color.Tan;
            this.RuleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RuleTextBox.Location = new System.Drawing.Point(38, 87);
            this.RuleTextBox.MaxLength = 50;
            this.RuleTextBox.Multiline = true;
            this.RuleTextBox.Name = "RuleTextBox";
            this.RuleTextBox.PlaceholderText = "Rule Text";
            this.RuleTextBox.Size = new System.Drawing.Size(456, 78);
            this.RuleTextBox.TabIndex = 49;
            // 
            // StaticCloseLabel
            // 
            this.StaticCloseLabel.AutoSize = true;
            this.StaticCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaticCloseLabel.Location = new System.Drawing.Point(499, 19);
            this.StaticCloseLabel.Name = "StaticCloseLabel";
            this.StaticCloseLabel.Size = new System.Drawing.Size(25, 29);
            this.StaticCloseLabel.TabIndex = 47;
            this.StaticCloseLabel.Text = "X";
            this.StaticCloseLabel.Click += new System.EventHandler(this.StaticCloseLabel_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tan;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(38, 257);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(197, 34);
            this.CancelButton.TabIndex = 46;
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
            this.ConfirmDataButton.Location = new System.Drawing.Point(274, 257);
            this.ConfirmDataButton.Name = "ConfirmDataButton";
            this.ConfirmDataButton.Size = new System.Drawing.Size(220, 34);
            this.ConfirmDataButton.TabIndex = 45;
            this.ConfirmDataButton.Text = "Подтвердить данные";
            this.ConfirmDataButton.UseVisualStyleBackColor = false;
            this.ConfirmDataButton.Click += new System.EventHandler(this.ConfirmDataButton_Click);
            // 
            // staticRedactLabel
            // 
            this.staticRedactLabel.AutoSize = true;
            this.staticRedactLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticRedactLabel.Location = new System.Drawing.Point(125, 19);
            this.staticRedactLabel.Name = "staticRedactLabel";
            this.staticRedactLabel.Size = new System.Drawing.Size(288, 39);
            this.staticRedactLabel.TabIndex = 44;
            this.staticRedactLabel.Text = "Добавление правила";
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(553, 328);
            this.Controls.Add(this.FineTextBox);
            this.Controls.Add(this.RuleTextBox);
            this.Controls.Add(this.StaticCloseLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmDataButton);
            this.Controls.Add(this.staticRedactLabel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRuleForm";
            this.Load += new System.EventHandler(this.AddRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FineTextBox;
        private TextBox RuleTextBox;
        private Label StaticCloseLabel;
        private Button CancelButton;
        private Button ConfirmDataButton;
        private Label staticRedactLabel;
    }
}