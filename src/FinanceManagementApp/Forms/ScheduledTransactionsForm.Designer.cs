namespace FinanceManagementApp.Forms
{
    partial class ScheduledTransactionsForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduledTransactionsForm));
            TransactionsDgv = new DataGridView();
            ResultValueLabel = new Label();
            ResultLabel = new Label();
            ExpensesValueLabel = new Label();
            ExpensesLabel = new Label();
            IncomingsValueLabel = new Label();
            IncomingsLabel = new Label();
            NewScheduledBtn = new Button();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            colDay = new DataGridViewTextBoxColumn();
            colRemaining = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TransactionsDgv).BeginInit();
            SuspendLayout();
            // 
            // TransactionsDgv
            // 
            TransactionsDgv.AllowUserToAddRows = false;
            TransactionsDgv.AllowUserToDeleteRows = false;
            TransactionsDgv.AllowUserToResizeColumns = false;
            TransactionsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(47, 47, 47);
            TransactionsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            TransactionsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TransactionsDgv.BackgroundColor = Color.FromArgb(50, 50, 50);
            TransactionsDgv.BorderStyle = BorderStyle.None;
            TransactionsDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TransactionsDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle6.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            TransactionsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            TransactionsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsDgv.Columns.AddRange(new DataGridViewColumn[] { colName, colType, colValue, colDay, colRemaining });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle7.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(70, 70, 74);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            TransactionsDgv.DefaultCellStyle = dataGridViewCellStyle7;
            TransactionsDgv.EnableHeadersVisualStyles = false;
            TransactionsDgv.GridColor = Color.FromArgb(63, 63, 63);
            TransactionsDgv.Location = new Point(35, 45);
            TransactionsDgv.MultiSelect = false;
            TransactionsDgv.Name = "TransactionsDgv";
            TransactionsDgv.ReadOnly = true;
            TransactionsDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle8.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            TransactionsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            TransactionsDgv.RowHeadersVisible = false;
            TransactionsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionsDgv.Size = new Size(649, 350);
            TransactionsDgv.TabIndex = 29;
            // 
            // ResultValueLabel
            // 
            ResultValueLabel.AutoSize = true;
            ResultValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ResultValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ResultValueLabel.Location = new Point(182, 475);
            ResultValueLabel.Name = "ResultValueLabel";
            ResultValueLabel.Size = new Size(84, 19);
            ResultValueLabel.TabIndex = 28;
            ResultValueLabel.Text = "R$ 0.000,00";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ResultLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ResultLabel.Location = new Point(37, 475);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(130, 19);
            ResultLabel.TabIndex = 27;
            ResultLabel.Text = "Resultado previsto:";
            // 
            // ExpensesValueLabel
            // 
            ExpensesValueLabel.AutoSize = true;
            ExpensesValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ExpensesValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesValueLabel.Location = new Point(182, 446);
            ExpensesValueLabel.Name = "ExpensesValueLabel";
            ExpensesValueLabel.Size = new Size(84, 19);
            ExpensesValueLabel.TabIndex = 26;
            ExpensesValueLabel.Text = "R$ 0.000,00";
            // 
            // ExpensesLabel
            // 
            ExpensesLabel.AutoSize = true;
            ExpensesLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ExpensesLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesLabel.Location = new Point(37, 446);
            ExpensesLabel.Name = "ExpensesLabel";
            ExpensesLabel.Size = new Size(135, 19);
            ExpensesLabel.TabIndex = 25;
            ExpensesLabel.Text = "Despesas previstas:";
            // 
            // IncomingsValueLabel
            // 
            IncomingsValueLabel.AutoSize = true;
            IncomingsValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            IncomingsValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsValueLabel.Location = new Point(182, 416);
            IncomingsValueLabel.Name = "IncomingsValueLabel";
            IncomingsValueLabel.Size = new Size(84, 19);
            IncomingsValueLabel.TabIndex = 24;
            IncomingsValueLabel.Text = "R$ 0.000,00";
            // 
            // IncomingsLabel
            // 
            IncomingsLabel.AutoSize = true;
            IncomingsLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            IncomingsLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsLabel.Location = new Point(37, 416);
            IncomingsLabel.Name = "IncomingsLabel";
            IncomingsLabel.Size = new Size(129, 19);
            IncomingsLabel.TabIndex = 23;
            IncomingsLabel.Text = "Receitas previstas:";
            // 
            // NewScheduledBtn
            // 
            NewScheduledBtn.BackColor = Color.FromArgb(70, 70, 74);
            NewScheduledBtn.Cursor = Cursors.Hand;
            NewScheduledBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            NewScheduledBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            NewScheduledBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            NewScheduledBtn.FlatStyle = FlatStyle.Flat;
            NewScheduledBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewScheduledBtn.ForeColor = Color.FromArgb(241, 241, 241);
            NewScheduledBtn.Location = new Point(538, 414);
            NewScheduledBtn.Name = "NewScheduledBtn";
            NewScheduledBtn.Size = new Size(146, 27);
            NewScheduledBtn.TabIndex = 22;
            NewScheduledBtn.Text = "+ Novo agendamento";
            NewScheduledBtn.UseVisualStyleBackColor = false;
            // 
            // colName
            // 
            colName.HeaderText = "Nome";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Tipo";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colValue
            // 
            colValue.HeaderText = "Valor";
            colValue.Name = "colValue";
            colValue.ReadOnly = true;
            // 
            // colDay
            // 
            colDay.HeaderText = "Dia";
            colDay.Name = "colDay";
            colDay.ReadOnly = true;
            // 
            // colRemaining
            // 
            colRemaining.HeaderText = "Recorrência";
            colRemaining.Name = "colRemaining";
            colRemaining.ReadOnly = true;
            // 
            // ScheduledTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(719, 539);
            Controls.Add(TransactionsDgv);
            Controls.Add(ResultValueLabel);
            Controls.Add(ResultLabel);
            Controls.Add(ExpensesValueLabel);
            Controls.Add(ExpensesLabel);
            Controls.Add(IncomingsValueLabel);
            Controls.Add(IncomingsLabel);
            Controls.Add(NewScheduledBtn);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ScheduledTransactions";
            Text = "ScheduledTransactions";
            ((System.ComponentModel.ISupportInitialize)TransactionsDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TransactionsDgv;
        private Label ResultValueLabel;
        private Label ResultLabel;
        private Label ExpensesValueLabel;
        private Label ExpensesLabel;
        private Label IncomingsValueLabel;
        private Label IncomingsLabel;
        private Button NewScheduledBtn;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colRemaining;
    }
}