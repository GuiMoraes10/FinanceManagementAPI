namespace FinanceManagementApp.Forms
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            NewTransactionBtn = new Button();
            FirstDateLabel = new Label();
            FirstDateDtp = new DateTimePicker();
            LastDateLabel = new Label();
            LastDateDtp = new DateTimePicker();
            TypeLabel = new Label();
            TypeCb = new ComboBox();
            CategoryCb = new ComboBox();
            CategoryLabel = new Label();
            FilterBtn = new Button();
            IncomingsLabel = new Label();
            IncomingsValueLabel = new Label();
            ExpensesValueLabel = new Label();
            ExpensesLabel = new Label();
            ResultValueLabel = new Label();
            ResultLabel = new Label();
            TransactionsDgv = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TransactionsDgv).BeginInit();
            SuspendLayout();
            // 
            // NewTransactionBtn
            // 
            NewTransactionBtn.BackColor = Color.FromArgb(70, 70, 74);
            NewTransactionBtn.Cursor = Cursors.Hand;
            NewTransactionBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            NewTransactionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            NewTransactionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            NewTransactionBtn.FlatStyle = FlatStyle.Flat;
            NewTransactionBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewTransactionBtn.ForeColor = Color.FromArgb(241, 241, 241);
            NewTransactionBtn.Location = new Point(553, 433);
            NewTransactionBtn.Name = "NewTransactionBtn";
            NewTransactionBtn.Size = new Size(130, 27);
            NewTransactionBtn.TabIndex = 3;
            NewTransactionBtn.Text = "+ Nova transação";
            NewTransactionBtn.UseVisualStyleBackColor = false;
            NewTransactionBtn.Click += NewTransactionBtn_Click;
            // 
            // FirstDateLabel
            // 
            FirstDateLabel.AutoSize = true;
            FirstDateLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            FirstDateLabel.ForeColor = Color.FromArgb(241, 241, 241);
            FirstDateLabel.Location = new Point(38, 34);
            FirstDateLabel.Name = "FirstDateLabel";
            FirstDateLabel.Size = new Size(77, 19);
            FirstDateLabel.TabIndex = 6;
            FirstDateLabel.Text = "Data início";
            // 
            // FirstDateDtp
            // 
            FirstDateDtp.CalendarForeColor = Color.FromArgb(241, 241, 241);
            FirstDateDtp.CalendarMonthBackground = Color.FromArgb(51, 51, 55);
            FirstDateDtp.CalendarTitleBackColor = Color.FromArgb(51, 51, 55);
            FirstDateDtp.CalendarTitleForeColor = Color.FromArgb(241, 241, 241);
            FirstDateDtp.Font = new Font("Bahnschrift SemiCondensed", 10F);
            FirstDateDtp.Format = DateTimePickerFormat.Short;
            FirstDateDtp.Location = new Point(124, 32);
            FirstDateDtp.Name = "FirstDateDtp";
            FirstDateDtp.ShowUpDown = true;
            FirstDateDtp.Size = new Size(78, 24);
            FirstDateDtp.TabIndex = 7;
            // 
            // LastDateLabel
            // 
            LastDateLabel.AutoSize = true;
            LastDateLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            LastDateLabel.ForeColor = Color.FromArgb(241, 241, 241);
            LastDateLabel.Location = new Point(216, 34);
            LastDateLabel.Name = "LastDateLabel";
            LastDateLabel.Size = new Size(64, 19);
            LastDateLabel.TabIndex = 8;
            LastDateLabel.Text = "Data fim";
            // 
            // LastDateDtp
            // 
            LastDateDtp.CalendarForeColor = Color.FromArgb(241, 241, 241);
            LastDateDtp.CalendarMonthBackground = Color.FromArgb(51, 51, 55);
            LastDateDtp.CalendarTitleBackColor = Color.FromArgb(51, 51, 55);
            LastDateDtp.CalendarTitleForeColor = Color.FromArgb(241, 241, 241);
            LastDateDtp.Font = new Font("Bahnschrift SemiCondensed", 10F);
            LastDateDtp.Format = DateTimePickerFormat.Short;
            LastDateDtp.Location = new Point(289, 32);
            LastDateDtp.Name = "LastDateDtp";
            LastDateDtp.ShowUpDown = true;
            LastDateDtp.Size = new Size(78, 24);
            LastDateDtp.TabIndex = 9;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            TypeLabel.ForeColor = Color.FromArgb(241, 241, 241);
            TypeLabel.Location = new Point(385, 34);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(35, 19);
            TypeLabel.TabIndex = 10;
            TypeLabel.Text = "Tipo";
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
            TypeCb.Location = new Point(438, 32);
            TypeCb.MaxDropDownItems = 10;
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(96, 24);
            TypeCb.TabIndex = 11;
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
            CategoryCb.Location = new Point(124, 80);
            CategoryCb.MaxDropDownItems = 10;
            CategoryCb.Name = "CategoryCb";
            CategoryCb.Size = new Size(156, 24);
            CategoryCb.TabIndex = 13;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            CategoryLabel.ForeColor = Color.FromArgb(241, 241, 241);
            CategoryLabel.Location = new Point(38, 80);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(70, 19);
            CategoryLabel.TabIndex = 12;
            CategoryLabel.Text = "Categoria";
            // 
            // FilterBtn
            // 
            FilterBtn.BackColor = Color.FromArgb(70, 70, 74);
            FilterBtn.Cursor = Cursors.Hand;
            FilterBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 90);
            FilterBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 100);
            FilterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 90);
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterBtn.ForeColor = Color.FromArgb(241, 241, 241);
            FilterBtn.Location = new Point(438, 78);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(96, 27);
            FilterBtn.TabIndex = 14;
            FilterBtn.Text = "Filtrar";
            FilterBtn.UseVisualStyleBackColor = false;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // IncomingsLabel
            // 
            IncomingsLabel.AutoSize = true;
            IncomingsLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            IncomingsLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsLabel.Location = new Point(36, 433);
            IncomingsLabel.Name = "IncomingsLabel";
            IncomingsLabel.Size = new Size(116, 19);
            IncomingsLabel.TabIndex = 15;
            IncomingsLabel.Text = "Total de receitas:";
            // 
            // IncomingsValueLabel
            // 
            IncomingsValueLabel.AutoSize = true;
            IncomingsValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            IncomingsValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            IncomingsValueLabel.Location = new Point(168, 433);
            IncomingsValueLabel.Name = "IncomingsValueLabel";
            IncomingsValueLabel.Size = new Size(84, 19);
            IncomingsValueLabel.TabIndex = 16;
            IncomingsValueLabel.Text = "R$ 0.000,00";
            // 
            // ExpensesValueLabel
            // 
            ExpensesValueLabel.AutoSize = true;
            ExpensesValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ExpensesValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesValueLabel.Location = new Point(168, 464);
            ExpensesValueLabel.Name = "ExpensesValueLabel";
            ExpensesValueLabel.Size = new Size(84, 19);
            ExpensesValueLabel.TabIndex = 18;
            ExpensesValueLabel.Text = "R$ 0.000,00";
            // 
            // ExpensesLabel
            // 
            ExpensesLabel.AutoSize = true;
            ExpensesLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ExpensesLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ExpensesLabel.Location = new Point(36, 464);
            ExpensesLabel.Name = "ExpensesLabel";
            ExpensesLabel.Size = new Size(124, 19);
            ExpensesLabel.TabIndex = 17;
            ExpensesLabel.Text = "Total de despesas:";
            // 
            // ResultValueLabel
            // 
            ResultValueLabel.AutoSize = true;
            ResultValueLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ResultValueLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ResultValueLabel.Location = new Point(168, 493);
            ResultValueLabel.Name = "ResultValueLabel";
            ResultValueLabel.Size = new Size(84, 19);
            ResultValueLabel.TabIndex = 20;
            ResultValueLabel.Text = "R$ 0.000,00";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Bahnschrift SemiCondensed", 12F);
            ResultLabel.ForeColor = Color.FromArgb(241, 241, 241);
            ResultLabel.Location = new Point(36, 493);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(75, 19);
            ResultLabel.TabIndex = 19;
            ResultLabel.Text = "Resultado:";
            // 
            // TransactionsDgv
            // 
            TransactionsDgv.AllowUserToAddRows = false;
            TransactionsDgv.AllowUserToDeleteRows = false;
            TransactionsDgv.AllowUserToResizeColumns = false;
            TransactionsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 47, 47);
            TransactionsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TransactionsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TransactionsDgv.BackgroundColor = Color.FromArgb(50, 50, 50);
            TransactionsDgv.BorderStyle = BorderStyle.None;
            TransactionsDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TransactionsDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TransactionsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TransactionsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsDgv.Columns.AddRange(new DataGridViewColumn[] { colDate, colName, colCategory, colType, colValue });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(70, 70, 74);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TransactionsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            TransactionsDgv.EnableHeadersVisualStyles = false;
            TransactionsDgv.GridColor = Color.FromArgb(63, 63, 63);
            TransactionsDgv.Location = new Point(34, 125);
            TransactionsDgv.MultiSelect = false;
            TransactionsDgv.Name = "TransactionsDgv";
            TransactionsDgv.ReadOnly = true;
            TransactionsDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(241, 241, 241);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TransactionsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TransactionsDgv.RowHeadersVisible = false;
            TransactionsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionsDgv.Size = new Size(649, 294);
            TransactionsDgv.TabIndex = 21;
            // 
            // colDate
            // 
            colDate.HeaderText = "Data";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Nome";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Categoria";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
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
            // Transactions
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
            Controls.Add(FilterBtn);
            Controls.Add(CategoryCb);
            Controls.Add(CategoryLabel);
            Controls.Add(TypeCb);
            Controls.Add(TypeLabel);
            Controls.Add(LastDateDtp);
            Controls.Add(LastDateLabel);
            Controls.Add(FirstDateDtp);
            Controls.Add(FirstDateLabel);
            Controls.Add(NewTransactionBtn);
            Font = new Font("Bahnschrift SemiCondensed", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Transactions";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)TransactionsDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FilterBtn;
        private ComboBox CategoryCb;
        private ComboBox TypeCb;
        private Label FirstDateLabel;
        private Label LastDateLabel;
        private Label TypeLabel;
        private Label CategoryLabel;
        private Label IncomingsLabel;
        private Label ExpensesLabel;
        private Label ExpensesValueLabel;
        private Label IncomingsValueLabel;
        private DateTimePicker LastDateDtp;
        private DateTimePicker FirstDateDtp;
        private Button NewTransactionBtn;
        private Label ResultValueLabel;
        private Label ResultLabel;
        private DataGridView TransactionsDgv;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colValue;
    }
}