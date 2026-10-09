namespace FinanceManagementApp.Forms.PopUps
{
    partial class ChangeBalancePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeBalancePopup));
            CloseBtn = new Button();
            TopPanel = new Panel();
            TitleLabel = new Label();
            NewBalanceLabel = new Label();
            NewBalanceTextBox = new TextBox();
            BalanceValueLabel = new Label();
            BalanceLabel = new Label();
            UpdateBtn = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
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
            TopPanel.TabIndex = 17;
            TopPanel.MouseDown += TopPanel_MouseDown;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Top;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(0, 29);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(365, 40);
            TitleLabel.TabIndex = 18;
            TitleLabel.Text = "Atualizar Saldo";
            TitleLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // NewBalanceLabel
            // 
            NewBalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            NewBalanceLabel.ForeColor = Color.FromArgb(241, 241, 241);
            NewBalanceLabel.Location = new Point(68, 150);
            NewBalanceLabel.Name = "NewBalanceLabel";
            NewBalanceLabel.Size = new Size(102, 27);
            NewBalanceLabel.TabIndex = 21;
            NewBalanceLabel.Text = "Novo saldo:";
            NewBalanceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NewBalanceTextBox
            // 
            NewBalanceTextBox.BackColor = Color.FromArgb(51, 51, 51);
            NewBalanceTextBox.BorderStyle = BorderStyle.FixedSingle;
            NewBalanceTextBox.Font = new Font("Bahnschrift SemiCondensed", 13F);
            NewBalanceTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            NewBalanceTextBox.Location = new Point(176, 149);
            NewBalanceTextBox.Name = "NewBalanceTextBox";
            NewBalanceTextBox.Size = new Size(114, 28);
            NewBalanceTextBox.TabIndex = 20;
            NewBalanceTextBox.KeyDown += NewBalanceTextBox_KeyDown;
            // 
            // BalanceValueLabel
            // 
            BalanceValueLabel.AutoSize = true;
            BalanceValueLabel.Font = new Font("Bahnschrift SemiCondensed", 14F);
            BalanceValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceValueLabel.Location = new Point(184, 108);
            BalanceValueLabel.Name = "BalanceValueLabel";
            BalanceValueLabel.Size = new Size(92, 23);
            BalanceValueLabel.TabIndex = 23;
            BalanceValueLabel.Text = "R$ 0.000,00";
            BalanceValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            BalanceLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceLabel.Location = new Point(68, 108);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(102, 27);
            BalanceLabel.TabIndex = 22;
            BalanceLabel.Text = "Saldo atual:";
            BalanceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(70, 70, 74);
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            UpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            UpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.FromArgb(241, 241, 241);
            UpdateBtn.Location = new Point(145, 212);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 27);
            UpdateBtn.TabIndex = 24;
            UpdateBtn.Text = "Atualizar";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ChangeBalancePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(365, 266);
            Controls.Add(UpdateBtn);
            Controls.Add(BalanceValueLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(NewBalanceLabel);
            Controls.Add(NewBalanceTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeBalancePopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeBalancePopup";
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseBtn;
        private Panel TopPanel;
        private Label TitleLabel;
        private Label NewBalanceLabel;
        private TextBox NewBalanceTextBox;
        private Label BalanceValueLabel;
        private Label BalanceLabel;
        private Button UpdateBtn;
    }
}