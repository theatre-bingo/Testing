namespace WindowFormsAssignment2.Window
{
    partial class TransactionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            Button Add;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TransactionDate = new DateTimePicker();
            TransactionAmount = new NumericUpDown();
            Back = new Button();
            Amount = new Label();
            Date = new Label();
            TransactionCategory = new ComboBox();
            Budget = new Label();
            TransactionHistory = new DataGridView();
            TransactionDetail = new GroupBox();
            Type = new Label();
            radioExpense = new RadioButton();
            radioIncome = new RadioButton();
            TransactionDescription = new TextBox();
            Description = new Label();
            THDate = new DataGridViewTextBoxColumn();
            THAmount = new DataGridViewTextBoxColumn();
            THDescription = new DataGridViewTextBoxColumn();
            THBudget = new DataGridViewTextBoxColumn();
            THType = new DataGridViewTextBoxColumn();
            Add = new Button();
            ((System.ComponentModel.ISupportInitialize)TransactionAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionHistory).BeginInit();
            TransactionDetail.SuspendLayout();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top;
            Add.Font = new Font("Segoe UI", 10F);
            Add.ForeColor = SystemColors.ControlText;
            Add.Location = new Point(645, 107);
            Add.Name = "Add";
            Add.Size = new Size(169, 37);
            Add.TabIndex = 0;
            Add.Text = "Add Transaction";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // TransactionDate
            // 
            TransactionDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TransactionDate.Location = new Point(18, 117);
            TransactionDate.Name = "TransactionDate";
            TransactionDate.Size = new Size(251, 27);
            TransactionDate.TabIndex = 2;
            // 
            // TransactionAmount
            // 
            TransactionAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TransactionAmount.AutoSize = true;
            TransactionAmount.DecimalPlaces = 2;
            TransactionAmount.Location = new Point(18, 55);
            TransactionAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            TransactionAmount.Name = "TransactionAmount";
            TransactionAmount.Size = new Size(251, 27);
            TransactionAmount.TabIndex = 3;
            TransactionAmount.ThousandsSeparator = true;
            TransactionAmount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Bottom;
            Back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Back.Font = new Font("Segoe UI", 12F);
            Back.Location = new Point(24, 466);
            Back.MinimumSize = new Size(190, 55);
            Back.Name = "Back";
            Back.Size = new Size(190, 55);
            Back.TabIndex = 0;
            Back.Text = "Back to Dashboard";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Amount
            // 
            Amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Amount.AutoSize = true;
            Amount.Location = new Point(18, 32);
            Amount.Name = "Amount";
            Amount.Size = new Size(62, 20);
            Amount.TabIndex = 5;
            Amount.Text = "Amount";
            // 
            // Date
            // 
            Date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Date.AutoSize = true;
            Date.Location = new Point(18, 94);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 6;
            Date.Text = "Date";
            // 
            // TransactionCategory
            // 
            TransactionCategory.AllowDrop = true;
            TransactionCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TransactionCategory.FormattingEnabled = true;
            TransactionCategory.Location = new Point(329, 55);
            TransactionCategory.Name = "TransactionCategory";
            TransactionCategory.Size = new Size(251, 28);
            TransactionCategory.TabIndex = 7;
            // 
            // Budget
            // 
            Budget.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Budget.AutoSize = true;
            Budget.Location = new Point(329, 32);
            Budget.Name = "Budget";
            Budget.Size = new Size(57, 20);
            Budget.TabIndex = 8;
            Budget.Text = "Budget";
            // 
            // TransactionHistory
            // 
            TransactionHistory.AllowUserToAddRows = false;
            TransactionHistory.AllowUserToResizeColumns = false;
            TransactionHistory.AllowUserToResizeRows = false;
            TransactionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TransactionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionHistory.Columns.AddRange(new DataGridViewColumn[] { THDate, THAmount, THDescription, THBudget, THType });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TransactionHistory.DefaultCellStyle = dataGridViewCellStyle2;
            TransactionHistory.Location = new Point(24, 229);
            TransactionHistory.Name = "TransactionHistory";
            TransactionHistory.RightToLeft = RightToLeft.No;
            TransactionHistory.RowHeadersVisible = false;
            TransactionHistory.RowHeadersWidth = 51;
            TransactionHistory.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TransactionHistory.Size = new Size(857, 216);
            TransactionHistory.TabIndex = 9;
            TransactionHistory.CellContentClick += TransactionHistory_CellContentClick;
            // 
            // TransactionDetail
            // 
            TransactionDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransactionDetail.Controls.Add(Type);
            TransactionDetail.Controls.Add(radioExpense);
            TransactionDetail.Controls.Add(radioIncome);
            TransactionDetail.Controls.Add(Add);
            TransactionDetail.Controls.Add(TransactionDescription);
            TransactionDetail.Controls.Add(Description);
            TransactionDetail.Controls.Add(Budget);
            TransactionDetail.Controls.Add(TransactionDate);
            TransactionDetail.Controls.Add(TransactionCategory);
            TransactionDetail.Controls.Add(Date);
            TransactionDetail.Controls.Add(TransactionAmount);
            TransactionDetail.Controls.Add(Amount);
            TransactionDetail.Location = new Point(24, 25);
            TransactionDetail.MinimumSize = new Size(857, 170);
            TransactionDetail.Name = "TransactionDetail";
            TransactionDetail.Size = new Size(857, 170);
            TransactionDetail.TabIndex = 11;
            TransactionDetail.TabStop = false;
            TransactionDetail.Text = "Transaction Details";
            // 
            // Type
            // 
            Type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Type.AutoSize = true;
            Type.Location = new Point(633, 32);
            Type.MinimumSize = new Size(40, 20);
            Type.Name = "Type";
            Type.Size = new Size(40, 20);
            Type.TabIndex = 13;
            Type.Text = "Type";
            // 
            // radioExpense
            // 
            radioExpense.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioExpense.AutoSize = true;
            radioExpense.Location = new Point(729, 55);
            radioExpense.MinimumSize = new Size(84, 24);
            radioExpense.Name = "radioExpense";
            radioExpense.Size = new Size(84, 24);
            radioExpense.TabIndex = 12;
            radioExpense.TabStop = true;
            radioExpense.Text = "Expense";
            radioExpense.UseVisualStyleBackColor = true;
            // 
            // radioIncome
            // 
            radioIncome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioIncome.AutoSize = true;
            radioIncome.Location = new Point(633, 55);
            radioIncome.MinimumSize = new Size(79, 24);
            radioIncome.Name = "radioIncome";
            radioIncome.Size = new Size(79, 24);
            radioIncome.TabIndex = 11;
            radioIncome.TabStop = true;
            radioIncome.Text = "Income";
            radioIncome.UseVisualStyleBackColor = true;
            // 
            // TransactionDescription
            // 
            TransactionDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TransactionDescription.Location = new Point(329, 117);
            TransactionDescription.Name = "TransactionDescription";
            TransactionDescription.Size = new Size(251, 27);
            TransactionDescription.TabIndex = 10;
            // 
            // Description
            // 
            Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Description.AutoSize = true;
            Description.Location = new Point(329, 94);
            Description.Name = "Description";
            Description.Size = new Size(85, 20);
            Description.TabIndex = 9;
            Description.Text = "Description";
            // 
            // THDate
            // 
            THDate.HeaderText = "Date";
            THDate.MinimumWidth = 6;
            THDate.Name = "THDate";
            THDate.Resizable = DataGridViewTriState.True;
            THDate.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // THAmount
            // 
            THAmount.HeaderText = "Amount";
            THAmount.MinimumWidth = 6;
            THAmount.Name = "THAmount";
            // 
            // THDescription
            // 
            THDescription.HeaderText = "Description";
            THDescription.MinimumWidth = 10;
            THDescription.Name = "THDescription";
            // 
            // THBudget
            // 
            THBudget.HeaderText = "Budget";
            THBudget.MinimumWidth = 6;
            THBudget.Name = "THBudget";
            // 
            // THType
            // 
            THType.HeaderText = "Type";
            THType.MinimumWidth = 6;
            THType.Name = "THType";
            // 
            // TransactionWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 551);
            Controls.Add(TransactionHistory);
            Controls.Add(Back);
            Controls.Add(TransactionDetail);
            Name = "TransactionWindow";
            Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)TransactionAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransactionHistory).EndInit();
            TransactionDetail.ResumeLayout(false);
            TransactionDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker TransactionDate;
        private NumericUpDown TransactionAmount;
        private Button Back;
        private Label Amount;
        private Label Date;
        private ComboBox TransactionCategory;
        private Label Budget;
        private DataGridView TransactionHistory;
        private GroupBox TransactionDetail;
        private Label Description;
        private TextBox TransactionDescription;
        private Label Type;
        private RadioButton radioExpense;
        private RadioButton radioIncome;
        private DataGridViewTextBoxColumn THDate;
        private DataGridViewTextBoxColumn THAmount;
        private DataGridViewTextBoxColumn THDescription;
        private DataGridViewTextBoxColumn THBudget;
        private DataGridViewTextBoxColumn THType;
    }
}