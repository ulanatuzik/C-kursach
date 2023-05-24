namespace ROV_TL.AdminForms.AdminAddtional
{
    partial class ViosForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViosLabel = new System.Windows.Forms.Label();
            this.AdminProfileLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CarsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ROVLabel = new System.Windows.Forms.Label();
            this.AdminsLabel = new System.Windows.Forms.Label();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.NotPayedViosButton = new System.Windows.Forms.Button();
            this.PayedVioButton = new System.Windows.Forms.Button();
            this.ActiveVioButton = new System.Windows.Forms.Button();
            this.CurrentPageLabel = new System.Windows.Forms.Label();
            this.CreateNewVio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.ViosLabel);
            this.panel1.Controls.Add(this.AdminProfileLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CarsLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ROVLabel);
            this.panel1.Controls.Add(this.AdminsLabel);
            this.panel1.Controls.Add(this.UsersLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 460);
            this.panel1.TabIndex = 16;
            // 
            // ViosLabel
            // 
            this.ViosLabel.AutoSize = true;
            this.ViosLabel.ForeColor = System.Drawing.Color.Black;
            this.ViosLabel.Location = new System.Drawing.Point(11, 216);
            this.ViosLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ViosLabel.Name = "ViosLabel";
            this.ViosLabel.Size = new System.Drawing.Size(119, 29);
            this.ViosLabel.TabIndex = 11;
            this.ViosLabel.Text = "Нарушения";
            // 
            // AdminProfileLabel
            // 
            this.AdminProfileLabel.AutoSize = true;
            this.AdminProfileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminProfileLabel.Location = new System.Drawing.Point(47, 62);
            this.AdminProfileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AdminProfileLabel.Name = "AdminProfileLabel";
            this.AdminProfileLabel.Size = new System.Drawing.Size(72, 29);
            this.AdminProfileLabel.TabIndex = 10;
            this.AdminProfileLabel.Text = "Admin";
            this.AdminProfileLabel.Click += new System.EventHandler(this.AdminProfileLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel3.Location = new System.Drawing.Point(1, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 5);
            this.panel3.TabIndex = 9;
            // 
            // CarsLabel
            // 
            this.CarsLabel.AutoSize = true;
            this.CarsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarsLabel.ForeColor = System.Drawing.Color.Black;
            this.CarsLabel.Location = new System.Drawing.Point(11, 180);
            this.CarsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarsLabel.Name = "CarsLabel";
            this.CarsLabel.Size = new System.Drawing.Size(126, 29);
            this.CarsLabel.TabIndex = 8;
            this.CarsLabel.Text = "Автомобили";
            this.CarsLabel.Click += new System.EventHandler(this.CarsLabel_Click);
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
            this.ROVLabel.ForeColor = System.Drawing.Color.Black;
            this.ROVLabel.Location = new System.Drawing.Point(33, 9);
            this.ROVLabel.Name = "ROVLabel";
            this.ROVLabel.Size = new System.Drawing.Size(99, 58);
            this.ROVLabel.TabIndex = 4;
            this.ROVLabel.Text = "ROV";
            // 
            // AdminsLabel
            // 
            this.AdminsLabel.AutoSize = true;
            this.AdminsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminsLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminsLabel.Location = new System.Drawing.Point(11, 109);
            this.AdminsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AdminsLabel.Name = "AdminsLabel";
            this.AdminsLabel.Size = new System.Drawing.Size(150, 29);
            this.AdminsLabel.TabIndex = 2;
            this.AdminsLabel.Text = "Администраторы";
            this.AdminsLabel.Click += new System.EventHandler(this.AdminsLabel_Click);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersLabel.ForeColor = System.Drawing.Color.Black;
            this.UsersLabel.Location = new System.Drawing.Point(11, 144);
            this.UsersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(142, 29);
            this.UsersLabel.TabIndex = 3;
            this.UsersLabel.Text = "Пользователи";
            this.UsersLabel.Click += new System.EventHandler(this.UsersLabel_Click);
            // 
            // NotPayedViosButton
            // 
            this.NotPayedViosButton.BackColor = System.Drawing.Color.Tan;
            this.NotPayedViosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotPayedViosButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotPayedViosButton.ForeColor = System.Drawing.Color.Black;
            this.NotPayedViosButton.Location = new System.Drawing.Point(250, 109);
            this.NotPayedViosButton.Name = "NotPayedViosButton";
            this.NotPayedViosButton.Size = new System.Drawing.Size(220, 74);
            this.NotPayedViosButton.TabIndex = 39;
            this.NotPayedViosButton.Text = "Неоплаченные штрафы";
            this.NotPayedViosButton.UseVisualStyleBackColor = false;
            this.NotPayedViosButton.Click += new System.EventHandler(this.NotPayedViosButton_Click);
            // 
            // PayedVioButton
            // 
            this.PayedVioButton.BackColor = System.Drawing.Color.Tan;
            this.PayedVioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayedVioButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayedVioButton.ForeColor = System.Drawing.Color.Black;
            this.PayedVioButton.Location = new System.Drawing.Point(569, 109);
            this.PayedVioButton.Name = "PayedVioButton";
            this.PayedVioButton.Size = new System.Drawing.Size(220, 74);
            this.PayedVioButton.TabIndex = 40;
            this.PayedVioButton.Text = "Оплаченные штрафы";
            this.PayedVioButton.UseVisualStyleBackColor = false;
            this.PayedVioButton.Click += new System.EventHandler(this.PayedVioButton_Click);
            // 
            // ActiveVioButton
            // 
            this.ActiveVioButton.BackColor = System.Drawing.Color.Tan;
            this.ActiveVioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveVioButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveVioButton.ForeColor = System.Drawing.Color.Black;
            this.ActiveVioButton.Location = new System.Drawing.Point(250, 229);
            this.ActiveVioButton.Name = "ActiveVioButton";
            this.ActiveVioButton.Size = new System.Drawing.Size(220, 74);
            this.ActiveVioButton.TabIndex = 41;
            this.ActiveVioButton.Text = "База активных правил";
            this.ActiveVioButton.UseVisualStyleBackColor = false;
            this.ActiveVioButton.Click += new System.EventHandler(this.ActiveVioButton_Click);
            // 
            // CurrentPageLabel
            // 
            this.CurrentPageLabel.AutoSize = true;
            this.CurrentPageLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentPageLabel.Location = new System.Drawing.Point(250, 32);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.Size = new System.Drawing.Size(539, 35);
            this.CurrentPageLabel.TabIndex = 46;
            this.CurrentPageLabel.Text = "Меню взаимодействия с нарушениями";
            // 
            // CreateNewVio
            // 
            this.CreateNewVio.BackColor = System.Drawing.Color.Tan;
            this.CreateNewVio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewVio.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewVio.ForeColor = System.Drawing.Color.Black;
            this.CreateNewVio.Location = new System.Drawing.Point(569, 229);
            this.CreateNewVio.Name = "CreateNewVio";
            this.CreateNewVio.Size = new System.Drawing.Size(220, 74);
            this.CreateNewVio.TabIndex = 47;
            this.CreateNewVio.Text = "Создать новое нарушение";
            this.CreateNewVio.UseVisualStyleBackColor = false;
            this.CreateNewVio.Click += new System.EventHandler(this.CreateNewVio_Click);
            // 
            // ViosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(867, 455);
            this.Controls.Add(this.CreateNewVio);
            this.Controls.Add(this.CurrentPageLabel);
            this.Controls.Add(this.ActiveVioButton);
            this.Controls.Add(this.PayedVioButton);
            this.Controls.Add(this.NotPayedViosButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ViosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label ViosLabel;
        private Label AdminProfileLabel;
        private Panel panel3;
        private Label CarsLabel;
        private Panel panel2;
        private Label ROVLabel;
        private Label AdminsLabel;
        private Label UsersLabel;
        private Button NotPayedViosButton;
        private Button PayedVioButton;
        private Button ActiveVioButton;
        private Label CurrentPageLabel;
        private Button CreateNewVio;
    }
}