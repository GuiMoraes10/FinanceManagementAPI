namespace FinanceManagementApp.Forms
{
    partial class FinancialProjectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialProjectionForm));
            panel1 = new Panel();
            YearProjectionValueLabel = new Label();
            YearProjectionLabel = new Label();
            panel2 = new Panel();
            MonthProjectionValueLabel = new Label();
            MonthProjectionLabel = new Label();
            BalancePanel = new Panel();
            BalanceValueLabel = new Label();
            BalanceLabel = new Label();
            DataDgv = new DataGridView();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            colMonth = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            colIncoming = new DataGridViewTextBoxColumn();
            colExpense = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            BalancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataDgv).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(YearProjectionValueLabel);
            panel1.Controls.Add(YearProjectionLabel);
            panel1.Location = new Point(517, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 74);
            panel1.TabIndex = 12;
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
            YearProjectionLabel.Location = new Point(48, 4);
            YearProjectionLabel.Name = "YearProjectionLabel";
            YearProjectionLabel.Size = new Size(69, 19);
            YearProjectionLabel.TabIndex = 7;
            YearProjectionLabel.Text = "Despesas";
            YearProjectionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(MonthProjectionValueLabel);
            panel2.Controls.Add(MonthProjectionLabel);
            panel2.Location = new Point(273, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 74);
            panel2.TabIndex = 13;
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
            MonthProjectionLabel.Location = new Point(51, 4);
            MonthProjectionLabel.Name = "MonthProjectionLabel";
            MonthProjectionLabel.Size = new Size(63, 19);
            MonthProjectionLabel.TabIndex = 7;
            MonthProjectionLabel.Text = "Receitas";
            MonthProjectionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BalancePanel
            // 
            BalancePanel.BackColor = Color.FromArgb(50, 50, 50);
            BalancePanel.BorderStyle = BorderStyle.FixedSingle;
            BalancePanel.Controls.Add(BalanceValueLabel);
            BalancePanel.Controls.Add(BalanceLabel);
            BalancePanel.Location = new Point(33, 48);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(165, 74);
            BalancePanel.TabIndex = 11;
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
            BalanceLabel.Location = new Point(61, 4);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(44, 19);
            BalanceLabel.TabIndex = 6;
            BalanceLabel.Text = "Saldo";
            BalanceLabel.TextAlign = ContentAlignment.TopCenter;
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
            DataDgv.Columns.AddRange(new DataGridViewColumn[] { colMonth, colBalance, colIncoming, colExpense });
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
            DataDgv.Location = new Point(33, 169);
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
            DataDgv.Size = new Size(649, 249);
            DataDgv.TabIndex = 37;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(122, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(165, 74);
            panel4.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 13F);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(34, 30);
            label5.Name = "label5";
            label5.Size = new Size(91, 22);
            label5.TabIndex = 7;
            label5.Text = "R$ 0.000,00";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 12F);
            label6.ForeColor = Color.FromArgb(241, 241, 241);
            label6.Location = new Point(13, 4);
            label6.Name = "label6";
            label6.Size = new Size(138, 19);
            label6.TabIndex = 6;
            label6.Text = "Receitas x Despesas";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(394, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(165, 74);
            panel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 13F);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 7;
            label1.Text = "R$ 0.000,00";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 12F);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(36, 4);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 6;
            label2.Text = "Projeção mês";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // colMonth
            // 
            colMonth.HeaderText = "Mes";
            colMonth.Name = "colMonth";
            colMonth.ReadOnly = true;
            // 
            // colBalance
            // 
            colBalance.HeaderText = "Saldo";
            colBalance.Name = "colBalance";
            colBalance.ReadOnly = true;
            // 
            // colIncoming
            // 
            colIncoming.HeaderText = "Receita";
            colIncoming.Name = "colIncoming";
            colIncoming.ReadOnly = true;
            // 
            // colExpense
            // 
            colExpense.HeaderText = "Despesa";
            colExpense.Name = "colExpense";
            colExpense.ReadOnly = true;
            // 
            // FinancialProjection
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(DataDgv);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(BalancePanel);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FinancialProjection";
            Text = "FinancialProjection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            BalancePanel.ResumeLayout(false);
            BalancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataDgv).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label YearProjectionValueLabel;
        private Label YearProjectionLabel;
        private Panel panel2;
        private Label MonthProjectionValueLabel;
        private Label MonthProjectionLabel;
        private Panel BalancePanel;
        private Label BalanceValueLabel;
        private Label BalanceLabel;
        private DataGridView DataDgv;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn colMonth;
        private DataGridViewTextBoxColumn colBalance;
        private DataGridViewTextBoxColumn colIncoming;
        private DataGridViewTextBoxColumn colExpense;
    }
}