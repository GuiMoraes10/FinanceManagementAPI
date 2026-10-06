namespace FinanceManagementApp.Forms
{
    partial class Investments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Investments));
            BalancePanel = new Panel();
            BalanceValueLabel = new Label();
            BalanceLabel = new Label();
            panel1 = new Panel();
            YearProjectionValueLabel = new Label();
            YearProjectionLabel = new Label();
            panel2 = new Panel();
            MonthProjectionValueLabel = new Label();
            MonthProjectionLabel = new Label();
            DepositBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            WithdrawBtn = new Button();
            NewInvestmentBtn = new Button();
            DataDgv = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            colIncoming = new DataGridViewTextBoxColumn();
            colMonthProj = new DataGridViewTextBoxColumn();
            colYearProj = new DataGridViewTextBoxColumn();
            BalancePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataDgv).BeginInit();
            SuspendLayout();
            // 
            // BalancePanel
            // 
            BalancePanel.BackColor = Color.FromArgb(50, 50, 50);
            BalancePanel.BorderStyle = BorderStyle.FixedSingle;
            BalancePanel.Controls.Add(BalanceValueLabel);
            BalancePanel.Controls.Add(BalanceLabel);
            BalancePanel.Location = new Point(32, 41);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(165, 74);
            BalancePanel.TabIndex = 2;
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
            BalanceLabel.Location = new Point(46, 4);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(66, 19);
            BalanceLabel.TabIndex = 6;
            BalanceLabel.Text = "Investido";
            BalanceLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(YearProjectionValueLabel);
            panel1.Controls.Add(YearProjectionLabel);
            panel1.Location = new Point(516, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 74);
            panel1.TabIndex = 9;
            // 
            // YearProjectionValueLabel
            // 
            YearProjectionValueLabel.AutoSize = true;
            YearProjectionValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            YearProjectionValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            YearProjectionValueLabel.Location = new Point(34, 30);
            YearProjectionValueLabel.Name = "YearProjectionValueLabel";
            YearProjectionValueLabel.Size = new Size(91, 22);
            YearProjectionValueLabel.TabIndex = 8;
            YearProjectionValueLabel.Text = "R$ 0.000,00";
            YearProjectionValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // YearProjectionLabel
            // 
            YearProjectionLabel.AutoSize = true;
            YearProjectionLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            YearProjectionLabel.ForeColor = Color.FromArgb(241, 241, 241);
            YearProjectionLabel.Location = new Point(15, 4);
            YearProjectionLabel.Name = "YearProjectionLabel";
            YearProjectionLabel.Size = new Size(133, 19);
            YearProjectionLabel.TabIndex = 7;
            YearProjectionLabel.Text = "Projeção (12 meses)";
            YearProjectionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(MonthProjectionValueLabel);
            panel2.Controls.Add(MonthProjectionLabel);
            panel2.Location = new Point(272, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 74);
            panel2.TabIndex = 10;
            // 
            // MonthProjectionValueLabel
            // 
            MonthProjectionValueLabel.AutoSize = true;
            MonthProjectionValueLabel.Font = new Font("Bahnschrift SemiCondensed", 13F);
            MonthProjectionValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            MonthProjectionValueLabel.Location = new Point(34, 30);
            MonthProjectionValueLabel.Name = "MonthProjectionValueLabel";
            MonthProjectionValueLabel.Size = new Size(91, 22);
            MonthProjectionValueLabel.TabIndex = 8;
            MonthProjectionValueLabel.Text = "R$ 0.000,00";
            MonthProjectionValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MonthProjectionLabel
            // 
            MonthProjectionLabel.AutoSize = true;
            MonthProjectionLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            MonthProjectionLabel.ForeColor = Color.FromArgb(241, 241, 241);
            MonthProjectionLabel.Location = new Point(30, 4);
            MonthProjectionLabel.Name = "MonthProjectionLabel";
            MonthProjectionLabel.Size = new Size(103, 19);
            MonthProjectionLabel.TabIndex = 7;
            MonthProjectionLabel.Text = "Projeção (mês)";
            MonthProjectionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DepositBtn
            // 
            DepositBtn.BackColor = Color.FromArgb(70, 70, 74);
            DepositBtn.Cursor = Cursors.Hand;
            DepositBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            DepositBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            DepositBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            DepositBtn.FlatStyle = FlatStyle.Flat;
            DepositBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositBtn.ForeColor = Color.FromArgb(241, 241, 241);
            DepositBtn.Location = new Point(32, 482);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(96, 27);
            DepositBtn.TabIndex = 31;
            DepositBtn.Text = "Depositar";
            DepositBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(70, 70, 74);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.FromArgb(241, 241, 241);
            DeleteBtn.Location = new Point(385, 482);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(96, 27);
            DeleteBtn.TabIndex = 32;
            DeleteBtn.Text = "Excluir";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(70, 70, 74);
            EditBtn.Cursor = Cursors.Hand;
            EditBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            EditBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            EditBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.FromArgb(241, 241, 241);
            EditBtn.Location = new Point(268, 482);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(96, 27);
            EditBtn.TabIndex = 33;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.BackColor = Color.FromArgb(70, 70, 74);
            WithdrawBtn.Cursor = Cursors.Hand;
            WithdrawBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            WithdrawBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            WithdrawBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            WithdrawBtn.FlatStyle = FlatStyle.Flat;
            WithdrawBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithdrawBtn.ForeColor = Color.FromArgb(241, 241, 241);
            WithdrawBtn.Location = new Point(149, 482);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(96, 27);
            WithdrawBtn.TabIndex = 34;
            WithdrawBtn.Text = "Retirar";
            WithdrawBtn.UseVisualStyleBackColor = false;
            // 
            // NewInvestmentBtn
            // 
            NewInvestmentBtn.BackColor = Color.FromArgb(70, 70, 74);
            NewInvestmentBtn.Cursor = Cursors.Hand;
            NewInvestmentBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            NewInvestmentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            NewInvestmentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            NewInvestmentBtn.FlatStyle = FlatStyle.Flat;
            NewInvestmentBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewInvestmentBtn.ForeColor = Color.FromArgb(241, 241, 241);
            NewInvestmentBtn.Location = new Point(32, 137);
            NewInvestmentBtn.Name = "NewInvestmentBtn";
            NewInvestmentBtn.Size = new Size(139, 27);
            NewInvestmentBtn.TabIndex = 35;
            NewInvestmentBtn.Text = "+ Novo investimento";
            NewInvestmentBtn.UseVisualStyleBackColor = false;
            // 
            // DataDgv
            // 
            DataDgv.AllowUserToAddRows = false;
            DataDgv.AllowUserToDeleteRows = false;
            DataDgv.AllowUserToResizeColumns = false;
            DataDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 47, 47);
            DataDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataDgv.BackgroundColor = Color.FromArgb(50, 50, 50);
            DataDgv.BorderStyle = BorderStyle.None;
            DataDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDgv.Columns.AddRange(new DataGridViewColumn[] { colName, colBalance, colIncoming, colMonthProj, colYearProj });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 74);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataDgv.DefaultCellStyle = dataGridViewCellStyle3;
            DataDgv.EnableHeadersVisualStyles = false;
            DataDgv.GridColor = Color.FromArgb(63, 63, 63);
            DataDgv.Location = new Point(32, 185);
            DataDgv.MultiSelect = false;
            DataDgv.Name = "DataDgv";
            DataDgv.ReadOnly = true;
            DataDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataDgv.RowHeadersVisible = false;
            DataDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataDgv.Size = new Size(649, 280);
            DataDgv.TabIndex = 36;
            // 
            // colName
            // 
            colName.HeaderText = "Investimento";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colBalance
            // 
            colBalance.HeaderText = "Saldo";
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            // 
            // colIncoming
            // 
            colIncoming.HeaderText = "Rendimento";
            colIncoming.Name = "colIncoming";
            colIncoming.ReadOnly = true;
            // 
            // colMonthProj
            // 
            colMonthProj.HeaderText = "Proj Mês";
            colMonthProj.Name = "colMonthProj";
            colMonthProj.ReadOnly = true;
            // 
            // colYearProj
            // 
            colYearProj.HeaderText = "Proj Ano";
            colYearProj.Name = "colYearProj";
            colYearProj.ReadOnly = true;
            // 
            // Investments
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(panel1);
            Controls.Add(DataDgv);
            Controls.Add(NewInvestmentBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(EditBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(DepositBtn);
            Controls.Add(panel2);
            Controls.Add(BalancePanel);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Investments";
            Text = "Investments";
            BalancePanel.ResumeLayout(false);
            BalancePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label YearProjectionValueLabel;
        private Label YearProjectionLabel;
        private Panel BalancePanel;
        private Label BalanceValueLabel;
        private Label BalanceLabel;
        private Panel panel2;
        private Label MonthProjectionValueLabel;
        private Label MonthProjectionLabel;
        private Button DepositBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button WithdrawBtn;
        private Button NewInvestmentBtn;
        private DataGridView DataDgv;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colBalance;
        private DataGridViewTextBoxColumn colIncoming;
        private DataGridViewTextBoxColumn colMonthProj;
        private DataGridViewTextBoxColumn colYearProj;
    }
}