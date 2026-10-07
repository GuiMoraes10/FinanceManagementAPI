namespace FinanceManagementApp.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            BalancePanel = new Panel();
            SaveProfileBtn = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            PasswordLabel = new Label();
            UserLabel = new Label();
            PasswordTextBox = new TextBox();
            UserTextBox = new TextBox();
            ProfileLabel = new Label();
            panel1 = new Panel();
            BalanceLabel = new Label();
            SaveFinancesBtn = new Button();
            BalanceTextBox = new TextBox();
            FinancesLabel = new Label();
            panel2 = new Panel();
            ApiValueLabel = new Label();
            ApiLabel = new Label();
            VersionValueLabel = new Label();
            VersionLabel = new Label();
            SystemLabel = new Label();
            BalancePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BalancePanel
            // 
            BalancePanel.BackColor = Color.FromArgb(50, 50, 50);
            BalancePanel.BorderStyle = BorderStyle.FixedSingle;
            BalancePanel.Controls.Add(SaveProfileBtn);
            BalancePanel.Controls.Add(NameLabel);
            BalancePanel.Controls.Add(NameTextBox);
            BalancePanel.Controls.Add(PasswordLabel);
            BalancePanel.Controls.Add(UserLabel);
            BalancePanel.Controls.Add(PasswordTextBox);
            BalancePanel.Controls.Add(UserTextBox);
            BalancePanel.Controls.Add(ProfileLabel);
            BalancePanel.Location = new Point(12, 32);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(695, 139);
            BalancePanel.TabIndex = 12;
            // 
            // SaveProfileBtn
            // 
            SaveProfileBtn.BackColor = Color.FromArgb(70, 70, 74);
            SaveProfileBtn.Cursor = Cursors.Hand;
            SaveProfileBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            SaveProfileBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            SaveProfileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            SaveProfileBtn.FlatStyle = FlatStyle.Flat;
            SaveProfileBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveProfileBtn.ForeColor = Color.FromArgb(241, 241, 241);
            SaveProfileBtn.Location = new Point(376, 58);
            SaveProfileBtn.Name = "SaveProfileBtn";
            SaveProfileBtn.Size = new Size(75, 27);
            SaveProfileBtn.TabIndex = 13;
            SaveProfileBtn.Text = "Salvar";
            SaveProfileBtn.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            NameLabel.ForeColor = Color.FromArgb(241, 241, 241);
            NameLabel.Location = new Point(125, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(47, 19);
            NameLabel.TabIndex = 12;
            NameLabel.Text = "Nome:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(51, 51, 51);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            NameTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            NameTextBox.Location = new Point(178, 18);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(137, 24);
            NameTextBox.TabIndex = 11;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            PasswordLabel.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordLabel.Location = new Point(121, 98);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(51, 19);
            PasswordLabel.TabIndex = 10;
            PasswordLabel.Text = "Senha:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            UserLabel.ForeColor = Color.FromArgb(241, 241, 241);
            UserLabel.Location = new Point(111, 60);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(61, 19);
            UserLabel.TabIndex = 9;
            UserLabel.Text = "Usuário:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(51, 51, 51);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            PasswordTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            PasswordTextBox.Location = new Point(178, 98);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(137, 24);
            PasswordTextBox.TabIndex = 8;
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.FromArgb(51, 51, 51);
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            UserTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            UserTextBox.Location = new Point(178, 58);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(137, 24);
            UserTextBox.TabIndex = 7;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Font = new Font("Bahnschrift SemiCondensed", 14F);
            ProfileLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ProfileLabel.Location = new Point(3, 2);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(49, 23);
            ProfileLabel.TabIndex = 6;
            ProfileLabel.Text = "Perfil";
            ProfileLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BalanceLabel);
            panel1.Controls.Add(SaveFinancesBtn);
            panel1.Controls.Add(BalanceTextBox);
            panel1.Controls.Add(FinancesLabel);
            panel1.Location = new Point(12, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 139);
            panel1.TabIndex = 13;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            BalanceLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceLabel.Location = new Point(125, 64);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(47, 19);
            BalanceLabel.TabIndex = 15;
            BalanceLabel.Text = "Saldo:";
            // 
            // SaveFinancesBtn
            // 
            SaveFinancesBtn.BackColor = Color.FromArgb(70, 70, 74);
            SaveFinancesBtn.Cursor = Cursors.Hand;
            SaveFinancesBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            SaveFinancesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            SaveFinancesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            SaveFinancesBtn.FlatStyle = FlatStyle.Flat;
            SaveFinancesBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveFinancesBtn.ForeColor = Color.FromArgb(241, 241, 241);
            SaveFinancesBtn.Location = new Point(376, 58);
            SaveFinancesBtn.Name = "SaveFinancesBtn";
            SaveFinancesBtn.Size = new Size(75, 27);
            SaveFinancesBtn.TabIndex = 14;
            SaveFinancesBtn.Text = "Salvar";
            SaveFinancesBtn.UseVisualStyleBackColor = false;
            // 
            // BalanceTextBox
            // 
            BalanceTextBox.BackColor = Color.FromArgb(51, 51, 51);
            BalanceTextBox.BorderStyle = BorderStyle.FixedSingle;
            BalanceTextBox.Font = new Font("Bahnschrift SemiCondensed", 10F);
            BalanceTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceTextBox.Location = new Point(178, 61);
            BalanceTextBox.Name = "BalanceTextBox";
            BalanceTextBox.Size = new Size(137, 24);
            BalanceTextBox.TabIndex = 14;
            // 
            // FinancesLabel
            // 
            FinancesLabel.AutoSize = true;
            FinancesLabel.Font = new Font("Bahnschrift SemiCondensed", 14F);
            FinancesLabel.ForeColor = Color.FromArgb(241, 241, 241);
            FinancesLabel.Location = new Point(3, 2);
            FinancesLabel.Name = "FinancesLabel";
            FinancesLabel.Size = new Size(87, 23);
            FinancesLabel.TabIndex = 6;
            FinancesLabel.Text = "Financeiro";
            FinancesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ApiValueLabel);
            panel2.Controls.Add(ApiLabel);
            panel2.Controls.Add(VersionValueLabel);
            panel2.Controls.Add(VersionLabel);
            panel2.Controls.Add(SystemLabel);
            panel2.Location = new Point(12, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 139);
            panel2.TabIndex = 14;
            // 
            // ApiValueLabel
            // 
            ApiValueLabel.AutoSize = true;
            ApiValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ApiValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ApiValueLabel.Location = new Point(353, 70);
            ApiValueLabel.Name = "ApiValueLabel";
            ApiValueLabel.Size = new Size(75, 19);
            ApiValueLabel.TabIndex = 17;
            ApiValueLabel.Text = "Conectada";
            // 
            // ApiLabel
            // 
            ApiLabel.AutoSize = true;
            ApiLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ApiLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ApiLabel.Location = new Point(314, 70);
            ApiLabel.Name = "ApiLabel";
            ApiLabel.Size = new Size(33, 19);
            ApiLabel.TabIndex = 16;
            ApiLabel.Text = "API:";
            // 
            // VersionValueLabel
            // 
            VersionValueLabel.AutoSize = true;
            VersionValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            VersionValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            VersionValueLabel.Location = new Point(353, 38);
            VersionValueLabel.Name = "VersionValueLabel";
            VersionValueLabel.Size = new Size(36, 19);
            VersionValueLabel.TabIndex = 15;
            VersionValueLabel.Text = "1.0.0";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            VersionLabel.ForeColor = Color.FromArgb(241, 241, 241);
            VersionLabel.Location = new Point(293, 38);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(54, 19);
            VersionLabel.TabIndex = 14;
            VersionLabel.Text = "Versão:";
            // 
            // SystemLabel
            // 
            SystemLabel.AutoSize = true;
            SystemLabel.Font = new Font("Bahnschrift SemiCondensed", 14F);
            SystemLabel.ForeColor = Color.FromArgb(241, 241, 241);
            SystemLabel.Location = new Point(3, 2);
            SystemLabel.Name = "SystemLabel";
            SystemLabel.Size = new Size(70, 23);
            SystemLabel.TabIndex = 6;
            SystemLabel.Text = "Sistema";
            SystemLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BalancePanel);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            Text = "Settings";
            BalancePanel.ResumeLayout(false);
            BalancePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BalancePanel;
        private Label ProfileLabel;
        private Panel panel1;
        private Label FinancesLabel;
        private Panel panel2;
        private Label SystemLabel;
        private Label PasswordLabel;
        private Label UserLabel;
        private TextBox PasswordTextBox;
        private TextBox UserTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button SaveProfileBtn;
        private Button SaveFinancesBtn;
        private Label BalanceLabel;
        private TextBox BalanceTextBox;
        private Label VersionValueLabel;
        private Label VersionLabel;
        private Label ApiValueLabel;
        private Label ApiLabel;
    }
}