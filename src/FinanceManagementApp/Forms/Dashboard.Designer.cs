namespace FinanceManagementApp.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BalancePanel = new Panel();
            BalanceValueLabel = new Label();
            BalanceLabel = new Label();
            IncomingsPanel = new Panel();
            IncomingsValueLabel = new Label();
            IncomingsLabel = new Label();
            ExpensesPanel = new Panel();
            ExpensesValueLabel = new Label();
            ExpensesLabel = new Label();
            panel1 = new Panel();
            BalanceProjectionValueLabel = new Label();
            BalanceProjectionLabel = new Label();
            panel2 = new Panel();
            InvestmentsValueLabel = new Label();
            InvestmentsLabel = new Label();
            panel3 = new Panel();
            LastTransactionsRtb = new RichTextBox();
            LastTransactionsLabel = new Label();
            panel4 = new Panel();
            NextScheduledRtb = new RichTextBox();
            NextScheduledLabel = new Label();
            BalancePanel.SuspendLayout();
            IncomingsPanel.SuspendLayout();
            ExpensesPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // BalancePanel
            // 
            BalancePanel.BackColor = Color.FromArgb(50, 50, 50);
            BalancePanel.BorderStyle = BorderStyle.FixedSingle;
            BalancePanel.Controls.Add(BalanceValueLabel);
            BalancePanel.Controls.Add(BalanceLabel);
            BalancePanel.Location = new Point(41, 61);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(165, 74);
            BalancePanel.TabIndex = 0;
            // 
            // BalanceValueLabel
            // 
            BalanceValueLabel.AutoSize = true;
            BalanceValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            BalanceValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceValueLabel.Location = new Point(34, 30);
            BalanceValueLabel.Name = "BalanceValueLabel";
            BalanceValueLabel.Size = new Size(91, 22);
            BalanceValueLabel.TabIndex = 7;
            BalanceValueLabel.Text = "R$ 0.000,00";
            BalanceValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            BalanceLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceLabel.Location = new Point(41, 4);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(81, 19);
            BalanceLabel.TabIndex = 6;
            BalanceLabel.Text = "Saldo atual";
            BalanceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // IncomingsPanel
            // 
            IncomingsPanel.BackColor = Color.FromArgb(50, 50, 50);
            IncomingsPanel.BorderStyle = BorderStyle.FixedSingle;
            IncomingsPanel.Controls.Add(IncomingsValueLabel);
            IncomingsPanel.Controls.Add(IncomingsLabel);
            IncomingsPanel.Location = new Point(270, 61);
            IncomingsPanel.Name = "IncomingsPanel";
            IncomingsPanel.Size = new Size(165, 74);
            IncomingsPanel.TabIndex = 1;
            // 
            // IncomingsValueLabel
            // 
            IncomingsValueLabel.AutoSize = true;
            IncomingsValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            IncomingsValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsValueLabel.Location = new Point(34, 30);
            IncomingsValueLabel.Name = "IncomingsValueLabel";
            IncomingsValueLabel.Size = new Size(91, 22);
            IncomingsValueLabel.TabIndex = 8;
            IncomingsValueLabel.Text = "R$ 0.000,00";
            IncomingsValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // IncomingsLabel
            // 
            IncomingsLabel.AutoSize = true;
            IncomingsLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            IncomingsLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsLabel.Location = new Point(50, 4);
            IncomingsLabel.Name = "IncomingsLabel";
            IncomingsLabel.Size = new Size(63, 19);
            IncomingsLabel.TabIndex = 7;
            IncomingsLabel.Text = "Receitas";
            IncomingsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExpensesPanel
            // 
            ExpensesPanel.BackColor = Color.FromArgb(50, 50, 50);
            ExpensesPanel.BorderStyle = BorderStyle.FixedSingle;
            ExpensesPanel.Controls.Add(ExpensesValueLabel);
            ExpensesPanel.Controls.Add(ExpensesLabel);
            ExpensesPanel.Location = new Point(497, 61);
            ExpensesPanel.Name = "ExpensesPanel";
            ExpensesPanel.Size = new Size(165, 74);
            ExpensesPanel.TabIndex = 2;
            // 
            // ExpensesValueLabel
            // 
            ExpensesValueLabel.AutoSize = true;
            ExpensesValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            ExpensesValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesValueLabel.Location = new Point(34, 30);
            ExpensesValueLabel.Name = "ExpensesValueLabel";
            ExpensesValueLabel.Size = new Size(91, 22);
            ExpensesValueLabel.TabIndex = 9;
            ExpensesValueLabel.Text = "R$ 0.000,00";
            ExpensesValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExpensesLabel
            // 
            ExpensesLabel.AutoSize = true;
            ExpensesLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ExpensesLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesLabel.Location = new Point(47, 4);
            ExpensesLabel.Name = "ExpensesLabel";
            ExpensesLabel.Size = new Size(69, 19);
            ExpensesLabel.TabIndex = 8;
            ExpensesLabel.Text = "Despesas";
            ExpensesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BalanceProjectionValueLabel);
            panel1.Controls.Add(BalanceProjectionLabel);
            panel1.Location = new Point(87, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 74);
            panel1.TabIndex = 1;
            // 
            // BalanceProjectionValueLabel
            // 
            BalanceProjectionValueLabel.AutoSize = true;
            BalanceProjectionValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            BalanceProjectionValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceProjectionValueLabel.Location = new Point(68, 30);
            BalanceProjectionValueLabel.Name = "BalanceProjectionValueLabel";
            BalanceProjectionValueLabel.Size = new Size(91, 22);
            BalanceProjectionValueLabel.TabIndex = 8;
            BalanceProjectionValueLabel.Text = "R$ 0.000,00";
            BalanceProjectionValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BalanceProjectionLabel
            // 
            BalanceProjectionLabel.AutoSize = true;
            BalanceProjectionLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            BalanceProjectionLabel.ForeColor = Color.FromArgb(241, 241, 241);
            BalanceProjectionLabel.Location = new Point(62, 4);
            BalanceProjectionLabel.Name = "BalanceProjectionLabel";
            BalanceProjectionLabel.Size = new Size(108, 19);
            BalanceProjectionLabel.TabIndex = 7;
            BalanceProjectionLabel.Text = "Saldo projetado";
            BalanceProjectionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(InvestmentsValueLabel);
            panel2.Controls.Add(InvestmentsLabel);
            panel2.Location = new Point(389, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 74);
            panel2.TabIndex = 2;
            // 
            // InvestmentsValueLabel
            // 
            InvestmentsValueLabel.AutoSize = true;
            InvestmentsValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            InvestmentsValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            InvestmentsValueLabel.Location = new Point(68, 30);
            InvestmentsValueLabel.Name = "InvestmentsValueLabel";
            InvestmentsValueLabel.Size = new Size(91, 22);
            InvestmentsValueLabel.TabIndex = 9;
            InvestmentsValueLabel.Text = "R$ 0.000,00";
            InvestmentsValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // InvestmentsLabel
            // 
            InvestmentsLabel.AutoSize = true;
            InvestmentsLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            InvestmentsLabel.ForeColor = Color.FromArgb(241, 241, 241);
            InvestmentsLabel.Location = new Point(69, 4);
            InvestmentsLabel.Name = "InvestmentsLabel";
            InvestmentsLabel.Size = new Size(97, 19);
            InvestmentsLabel.TabIndex = 8;
            InvestmentsLabel.Text = "Investimentos";
            InvestmentsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LastTransactionsRtb);
            panel3.Controls.Add(LastTransactionsLabel);
            panel3.Location = new Point(87, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 166);
            panel3.TabIndex = 2;
            // 
            // LastTransactionsRtb
            // 
            LastTransactionsRtb.BackColor = Color.FromArgb(50, 50, 50);
            LastTransactionsRtb.BorderStyle = BorderStyle.None;
            LastTransactionsRtb.Location = new Point(24, 34);
            LastTransactionsRtb.Name = "LastTransactionsRtb";
            LastTransactionsRtb.Size = new Size(188, 119);
            LastTransactionsRtb.TabIndex = 11;
            LastTransactionsRtb.Text = "";
            // 
            // LastTransactionsLabel
            // 
            LastTransactionsLabel.AutoSize = true;
            LastTransactionsLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            LastTransactionsLabel.ForeColor = Color.FromArgb(241, 241, 241);
            LastTransactionsLabel.Location = new Point(53, 4);
            LastTransactionsLabel.Name = "LastTransactionsLabel";
            LastTransactionsLabel.Size = new Size(132, 19);
            LastTransactionsLabel.TabIndex = 8;
            LastTransactionsLabel.Text = "Ultimas transações";
            LastTransactionsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(NextScheduledRtb);
            panel4.Controls.Add(NextScheduledLabel);
            panel4.Location = new Point(389, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 166);
            panel4.TabIndex = 3;
            // 
            // NextScheduledRtb
            // 
            NextScheduledRtb.BackColor = Color.FromArgb(50, 50, 50);
            NextScheduledRtb.BorderStyle = BorderStyle.None;
            NextScheduledRtb.Location = new Point(24, 34);
            NextScheduledRtb.Name = "NextScheduledRtb";
            NextScheduledRtb.Size = new Size(188, 119);
            NextScheduledRtb.TabIndex = 10;
            NextScheduledRtb.Text = "";
            // 
            // NextScheduledLabel
            // 
            NextScheduledLabel.AutoSize = true;
            NextScheduledLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            NextScheduledLabel.ForeColor = Color.FromArgb(241, 241, 241);
            NextScheduledLabel.Location = new Point(35, 4);
            NextScheduledLabel.Name = "NextScheduledLabel";
            NextScheduledLabel.Size = new Size(164, 19);
            NextScheduledLabel.TabIndex = 9;
            NextScheduledLabel.Text = "Próximos agendamentos";
            NextScheduledLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ExpensesPanel);
            Controls.Add(IncomingsPanel);
            Controls.Add(BalancePanel);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            BalancePanel.ResumeLayout(false);
            BalancePanel.PerformLayout();
            IncomingsPanel.ResumeLayout(false);
            IncomingsPanel.PerformLayout();
            ExpensesPanel.ResumeLayout(false);
            ExpensesPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BalancePanel;
        private Panel IncomingsPanel;
        private Panel ExpensesPanel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label BalanceLabel;
        private Label IncomingsLabel;
        private Label ExpensesLabel;
        private Label BalanceProjectionLabel;
        private Label InvestmentsLabel;
        private Label BalanceValueLabel;
        private Label IncomingsValueLabel;
        private Label ExpensesValueLabel;
        private Label LastTransactionsLabel;
        private Label NextScheduledLabel;
        private Label BalanceProjectionValueLabel;
        private Label InvestmentsValueLabel;
        private RichTextBox LastTransactionsRtb;
        private RichTextBox NextScheduledRtb;
    }
}