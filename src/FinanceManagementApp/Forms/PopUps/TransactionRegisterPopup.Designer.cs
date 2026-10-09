namespace FinanceManagementApp.Forms.PopUps
{
    partial class TransactionRegisterPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionRegisterPopup));
            TopPanel = new Panel();
            CloseBtn = new Button();
            RegisterBtn = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            ValueLabel = new Label();
            ValueTextBox = new TextBox();
            TitleLabel = new Label();
            CategoryCb = new ComboBox();
            CategoryLabel = new Label();
            TypeCb = new ComboBox();
            TypeLabel = new Label();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(37, 37, 38);
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(365, 29);
            TopPanel.TabIndex = 18;
            TopPanel.MouseDown += TopPanel_MouseDown;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(45, 45, 48);
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Dock = DockStyle.Right;
            CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 50, 50);
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 60, 60);
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Microsoft Sans Serif", 10F);
            CloseBtn.ForeColor = Color.FromArgb(184, 184, 184);
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(335, 0);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(28, 27);
            CloseBtn.TabIndex = 0;
            CloseBtn.TextAlign = ContentAlignment.MiddleRight;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(70, 70, 74);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            RegisterBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            RegisterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBtn.ForeColor = Color.FromArgb(241, 241, 241);
            RegisterBtn.Location = new Point(144, 223);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 27);
            RegisterBtn.TabIndex = 17;
            RegisterBtn.Text = "Registrar";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            NameLabel.ForeColor = Color.FromArgb(241, 241, 241);
            NameLabel.Location = new Point(81, 88);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 19);
            NameLabel.TabIndex = 22;
            NameLabel.Text = "Nome:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(51, 51, 51);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            NameTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            NameTextBox.Location = new Point(134, 87);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(137, 24);
            NameTextBox.TabIndex = 19;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ValueLabel.Location = new Point(84, 120);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(44, 19);
            ValueLabel.TabIndex = 21;
            ValueLabel.Text = "Valor:";
            // 
            // ValueTextBox
            // 
            ValueTextBox.BackColor = Color.FromArgb(51, 51, 51);
            ValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            ValueTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            ValueTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            ValueTextBox.Location = new Point(134, 119);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(137, 24);
            ValueTextBox.TabIndex = 20;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(0, 29);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(365, 40);
            TitleLabel.TabIndex = 23;
            TitleLabel.Text = "Registrar transação";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CategoryCb
            // 
            CategoryCb.BackColor = Color.FromArgb(51, 51, 55);
            CategoryCb.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryCb.FlatStyle = FlatStyle.Flat;
            CategoryCb.Font = new Font("Bahnschrift SemiCondensed", 10F);
            CategoryCb.ForeColor = Color.FromArgb(241, 241, 241);
            CategoryCb.FormattingEnabled = true;
            CategoryCb.IntegralHeight = false;
            CategoryCb.Items.AddRange(new object[] { "Conta", "Comida", "Transporte", "Lazer", "Cartão de crédito", "Investimentos", "Salário", "Outros" });
            CategoryCb.Location = new Point(134, 150);
            CategoryCb.MaxDropDownItems = 10;
            CategoryCb.Name = "CategoryCb";
            CategoryCb.Size = new Size(137, 24);
            CategoryCb.TabIndex = 27;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            CategoryLabel.ForeColor = Color.FromArgb(241, 241, 241);
            CategoryLabel.Location = new Point(55, 150);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(73, 19);
            CategoryLabel.TabIndex = 26;
            CategoryLabel.Text = "Categoria:";
            // 
            // TypeCb
            // 
            TypeCb.BackColor = Color.FromArgb(51, 51, 55);
            TypeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeCb.FlatStyle = FlatStyle.Flat;
            TypeCb.Font = new Font("Bahnschrift SemiCondensed", 10F);
            TypeCb.ForeColor = Color.FromArgb(241, 241, 241);
            TypeCb.FormattingEnabled = true;
            TypeCb.IntegralHeight = false;
            TypeCb.Items.AddRange(new object[] { "Entradas", "Saídas" });
            TypeCb.Location = new Point(134, 182);
            TypeCb.MaxDropDownItems = 10;
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(137, 24);
            TypeCb.TabIndex = 25;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            TypeLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TypeLabel.Location = new Point(90, 182);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(38, 19);
            TypeLabel.TabIndex = 24;
            TypeLabel.Text = "Tipo:";
            // 
            // TransactionRegisterPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(365, 266);
            Controls.Add(CategoryCb);
            Controls.Add(CategoryLabel);
            Controls.Add(TypeCb);
            Controls.Add(TypeLabel);
            Controls.Add(TitleLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(ValueLabel);
            Controls.Add(ValueTextBox);
            Controls.Add(TopPanel);
            Controls.Add(RegisterBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TransactionRegisterPopup";
            Text = "TransactionRegisterPopup";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Button CloseBtn;
        private Button RegisterBtn;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label ValueLabel;
        private TextBox ValueTextBox;
        private Label TitleLabel;
        private ComboBox CategoryCb;
        private Label CategoryLabel;
        private ComboBox TypeCb;
        private Label TypeLabel;
    }
}