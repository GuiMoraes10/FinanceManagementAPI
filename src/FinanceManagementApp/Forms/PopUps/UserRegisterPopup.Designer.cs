namespace FinanceManagementApp.Forms.PopUps
{
    partial class UserRegisterPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterPopup));
            PasswordLabel = new Label();
            UserLabel = new Label();
            RegisterBtn = new Button();
            PasswordTextBox = new TextBox();
            UserTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CofirmPasswordLabel = new Label();
            CofirmPasswordTextBox = new TextBox();
            TopPanel = new Panel();
            CloseBtn = new Button();
            TitleLabel = new Label();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            PasswordLabel.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordLabel.Location = new Point(87, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(51, 19);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Senha:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            UserLabel.ForeColor = Color.FromArgb(241, 241, 241);
            UserLabel.Location = new Point(77, 114);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(61, 19);
            UserLabel.TabIndex = 10;
            UserLabel.Text = "Usuário:";
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
            RegisterBtn.Location = new Point(144, 219);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 27);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Registrar";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(51, 51, 51);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            PasswordTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordTextBox.Location = new Point(144, 145);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(137, 24);
            PasswordTextBox.TabIndex = 3;
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.FromArgb(51, 51, 51);
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            UserTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            UserTextBox.Location = new Point(144, 113);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(137, 24);
            UserTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            NameLabel.ForeColor = Color.FromArgb(241, 241, 241);
            NameLabel.Location = new Point(91, 82);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 19);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Nome:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(51, 51, 51);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            NameTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            NameTextBox.Location = new Point(144, 81);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(137, 24);
            NameTextBox.TabIndex = 1;
            // 
            // CofirmPasswordLabel
            // 
            CofirmPasswordLabel.AutoSize = true;
            CofirmPasswordLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            CofirmPasswordLabel.ForeColor = Color.FromArgb(241, 241, 241);
            CofirmPasswordLabel.Location = new Point(20, 178);
            CofirmPasswordLabel.Name = "CofirmPasswordLabel";
            CofirmPasswordLabel.Size = new Size(118, 19);
            CofirmPasswordLabel.TabIndex = 15;
            CofirmPasswordLabel.Text = "Confirmar senha:";
            // 
            // CofirmPasswordTextBox
            // 
            CofirmPasswordTextBox.BackColor = Color.FromArgb(51, 51, 51);
            CofirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            CofirmPasswordTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            CofirmPasswordTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            CofirmPasswordTextBox.Location = new Point(144, 177);
            CofirmPasswordTextBox.Name = "CofirmPasswordTextBox";
            CofirmPasswordTextBox.PasswordChar = '*';
            CofirmPasswordTextBox.Size = new Size(137, 24);
            CofirmPasswordTextBox.TabIndex = 4;
            CofirmPasswordTextBox.KeyDown += CofirmPasswordTextBox_KeyDown;
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
            TopPanel.TabIndex = 16;
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
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(0, 29);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(365, 32);
            TitleLabel.TabIndex = 17;
            TitleLabel.Text = "Registro de usuário";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // UserRegisterPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(365, 266);
            Controls.Add(TitleLabel);
            Controls.Add(TopPanel);
            Controls.Add(CofirmPasswordLabel);
            Controls.Add(CofirmPasswordTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(RegisterBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserRegisterPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRegisterMessageBox";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private Label UserLabel;
        private Button RegisterBtn;
        private TextBox PasswordTextBox;
        private TextBox UserTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label CofirmPasswordLabel;
        private TextBox CofirmPasswordTextBox;
        private Panel TopPanel;
        private Button CloseBtn;
        private Label TitleLabel;
    }
}