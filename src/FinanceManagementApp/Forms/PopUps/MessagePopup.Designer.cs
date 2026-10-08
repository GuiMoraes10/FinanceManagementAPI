namespace FinanceManagementApp.Forms.PopUps
{
    partial class MessagePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagePopup));
            TopPanel = new Panel();
            TitleLabel = new Label();
            CloseBtn = new Button();
            OkBtn = new Button();
            MessageLabel = new Label();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(37, 37, 38);
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(365, 29);
            TopPanel.TabIndex = 8;
            TopPanel.MouseDown += TopPanel_MouseDown;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            TitleLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TitleLabel.Location = new Point(3, 4);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(44, 19);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Título";
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
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(70, 70, 74);
            OkBtn.Cursor = Cursors.Hand;
            OkBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            OkBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            OkBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OkBtn.ForeColor = Color.FromArgb(241, 241, 241);
            OkBtn.Location = new Point(145, 137);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(75, 27);
            OkBtn.TabIndex = 10;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            MessageLabel.ForeColor = Color.FromArgb(241, 241, 241);
            MessageLabel.Location = new Point(28, 74);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(310, 19);
            MessageLabel.TabIndex = 13;
            MessageLabel.Text = "Texto do TextBox personalizado";
            MessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MessagePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(365, 191);
            Controls.Add(MessageLabel);
            Controls.Add(OkBtn);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessagePopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBox";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Button CloseBtn;
        private Button OkBtn;
        private Label TitleLabel;
        private Label MessageLabel;
    }
}