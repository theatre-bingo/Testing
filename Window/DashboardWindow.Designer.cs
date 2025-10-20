namespace WindowFormsAssignment2.Window
{
    partial class DashboardWindow
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
            panel1 = new Panel();
            userHeading = new Label();
            label1 = new Label();
            panel6 = new Panel();
            budgetDGV = new DataGridView();
            label9 = new Label();
            panel5 = new Panel();
            budgetInstructionLbl = new Label();
            label8 = new Label();
            transactionsDGV = new DataGridView();
            budgFilterCB = new ComboBox();
            panel3 = new Panel();
            accBalLbl = new Label();
            label5 = new Label();
            panel4 = new Panel();
            warningLbl = new Label();
            label7 = new Label();
            panel2 = new Panel();
            dayLbl = new Label();
            dayHeadingLbl = new Label();
            panel7 = new Panel();
            transactB = new Button();
            panel8 = new Panel();
            budgB = new Button();
            panel9 = new Panel();
            logB = new Button();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)budgetDGV).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsDGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(userHeading);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 95);
            panel1.TabIndex = 1;
            // 
            // userHeading
            // 
            userHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userHeading.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            userHeading.Location = new Point(0, 40);
            userHeading.Name = "userHeading";
            userHeading.Size = new Size(800, 55);
            userHeading.TabIndex = 3;
            userHeading.Text = "FName LName";
            userHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(800, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Personal Finance Tracker Dashboard";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(budgetDGV);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(210, 299);
            panel6.Name = "panel6";
            panel6.Size = new Size(590, 151);
            panel6.TabIndex = 6;
            // 
            // budgetDGV
            // 
            budgetDGV.AllowUserToAddRows = false;
            budgetDGV.AllowUserToDeleteRows = false;
            budgetDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            budgetDGV.BackgroundColor = SystemColors.ControlLight;
            budgetDGV.BorderStyle = BorderStyle.None;
            budgetDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            budgetDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            budgetDGV.ColumnHeadersHeight = 29;
            budgetDGV.Dock = DockStyle.Bottom;
            budgetDGV.Location = new Point(0, 25);
            budgetDGV.MultiSelect = false;
            budgetDGV.Name = "budgetDGV";
            budgetDGV.ReadOnly = true;
            budgetDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            budgetDGV.RowHeadersVisible = false;
            budgetDGV.RowHeadersWidth = 51;
            budgetDGV.Size = new Size(590, 126);
            budgetDGV.TabIndex = 4;
            budgetDGV.SelectionChanged += budgetDGV_SelectionChanged;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(590, 25);
            label9.TabIndex = 2;
            label9.Text = "Budget Balance";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(budgetInstructionLbl);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(transactionsDGV);
            panel5.Controls.Add(budgFilterCB);
            panel5.Location = new Point(210, 140);
            panel5.Name = "panel5";
            panel5.Size = new Size(590, 153);
            panel5.TabIndex = 7;
            // 
            // budgetInstructionLbl
            // 
            budgetInstructionLbl.AutoSize = true;
            budgetInstructionLbl.BackColor = Color.Transparent;
            budgetInstructionLbl.Location = new Point(212, 31);
            budgetInstructionLbl.Name = "budgetInstructionLbl";
            budgetInstructionLbl.Size = new Size(130, 20);
            budgetInstructionLbl.TabIndex = 5;
            budgetInstructionLbl.Text = "Budget to filter by";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(590, 25);
            label8.TabIndex = 2;
            label8.Text = "Recent Transactions";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // transactionsDGV
            // 
            transactionsDGV.AllowUserToAddRows = false;
            transactionsDGV.AllowUserToDeleteRows = false;
            transactionsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionsDGV.BackgroundColor = SystemColors.ControlLight;
            transactionsDGV.BorderStyle = BorderStyle.None;
            transactionsDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            transactionsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            transactionsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDGV.Dock = DockStyle.Bottom;
            transactionsDGV.Location = new Point(0, 58);
            transactionsDGV.MultiSelect = false;
            transactionsDGV.Name = "transactionsDGV";
            transactionsDGV.ReadOnly = true;
            transactionsDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            transactionsDGV.RowHeadersVisible = false;
            transactionsDGV.RowHeadersWidth = 51;
            transactionsDGV.Size = new Size(590, 95);
            transactionsDGV.TabIndex = 3;
            transactionsDGV.SelectionChanged += transactionsDGV_SelectionChanged;
            // 
            // budgFilterCB
            // 
            budgFilterCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            budgFilterCB.FormattingEnabled = true;
            budgFilterCB.Location = new Point(0, 28);
            budgFilterCB.Name = "budgFilterCB";
            budgFilterCB.Size = new Size(206, 28);
            budgFilterCB.TabIndex = 4;
            budgFilterCB.SelectedIndexChanged += budgFilterCB_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(accBalLbl);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 241);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 109);
            panel3.TabIndex = 4;
            // 
            // accBalLbl
            // 
            accBalLbl.BackColor = SystemColors.ButtonFace;
            accBalLbl.Dock = DockStyle.Fill;
            accBalLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accBalLbl.Location = new Point(0, 25);
            accBalLbl.Name = "accBalLbl";
            accBalLbl.Size = new Size(204, 84);
            accBalLbl.TabIndex = 3;
            accBalLbl.Text = "$0.00";
            accBalLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 25);
            label5.TabIndex = 2;
            label5.Text = "Account Balance";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(warningLbl);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(0, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 94);
            panel4.TabIndex = 4;
            // 
            // warningLbl
            // 
            warningLbl.BackColor = SystemColors.ButtonFace;
            warningLbl.Dock = DockStyle.Fill;
            warningLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            warningLbl.Location = new Point(0, 25);
            warningLbl.Name = "warningLbl";
            warningLbl.Size = new Size(204, 69);
            warningLbl.TabIndex = 3;
            warningLbl.Text = "No warnings to display.";
            warningLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(204, 25);
            label7.TabIndex = 2;
            label7.Text = "Warnings";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dayLbl);
            panel2.Controls.Add(dayHeadingLbl);
            panel2.Location = new Point(0, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 95);
            panel2.TabIndex = 5;
            // 
            // dayLbl
            // 
            dayLbl.BackColor = SystemColors.ButtonFace;
            dayLbl.Dock = DockStyle.Fill;
            dayLbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayLbl.Location = new Point(0, 25);
            dayLbl.Name = "dayLbl";
            dayLbl.Size = new Size(204, 70);
            dayLbl.TabIndex = 3;
            dayLbl.Text = "0";
            dayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayHeadingLbl
            // 
            dayHeadingLbl.BackColor = SystemColors.ButtonHighlight;
            dayHeadingLbl.BorderStyle = BorderStyle.FixedSingle;
            dayHeadingLbl.Dock = DockStyle.Top;
            dayHeadingLbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dayHeadingLbl.Location = new Point(0, 0);
            dayHeadingLbl.Name = "dayHeadingLbl";
            dayHeadingLbl.Size = new Size(204, 25);
            dayHeadingLbl.TabIndex = 2;
            dayHeadingLbl.Text = "Budget Time Period (Days)";
            dayHeadingLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(transactB);
            panel7.Location = new Point(0, -3);
            panel7.Name = "panel7";
            panel7.Size = new Size(119, 36);
            panel7.TabIndex = 8;
            // 
            // transactB
            // 
            transactB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactB.BackColor = SystemColors.ControlDarkDark;
            transactB.FlatStyle = FlatStyle.Flat;
            transactB.ForeColor = SystemColors.ControlLightLight;
            transactB.Location = new Point(0, 0);
            transactB.Name = "transactB";
            transactB.Size = new Size(119, 36);
            transactB.TabIndex = 0;
            transactB.Text = "Transactions";
            transactB.UseVisualStyleBackColor = false;
            transactB.Click += transactB_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(budgB);
            panel8.Location = new Point(116, -3);
            panel8.Name = "panel8";
            panel8.Size = new Size(119, 36);
            panel8.TabIndex = 9;
            // 
            // budgB
            // 
            budgB.BackColor = SystemColors.ControlDarkDark;
            budgB.Dock = DockStyle.Fill;
            budgB.FlatStyle = FlatStyle.Flat;
            budgB.ForeColor = SystemColors.ControlLightLight;
            budgB.Location = new Point(0, 0);
            budgB.Name = "budgB";
            budgB.Size = new Size(119, 36);
            budgB.TabIndex = 0;
            budgB.Text = "Budgets";
            budgB.UseVisualStyleBackColor = false;
            budgB.Click += budgB_Click;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(logB);
            panel9.Location = new Point(231, -3);
            panel9.Name = "panel9";
            panel9.Size = new Size(119, 36);
            panel9.TabIndex = 9;
            // 
            // logB
            // 
            logB.BackColor = SystemColors.ControlDarkDark;
            logB.Dock = DockStyle.Fill;
            logB.FlatStyle = FlatStyle.Flat;
            logB.ForeColor = SystemColors.ControlLightLight;
            logB.Location = new Point(0, 0);
            logB.Name = "logB";
            logB.Size = new Size(119, 36);
            logB.TabIndex = 0;
            logB.Text = "Logout";
            logB.UseVisualStyleBackColor = false;
            logB.Click += logB_Click;
            // 
            // DashboardWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "DashboardWindow";
            Text = "Dashboard";
            Load += DashboardWindow_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)budgetDGV).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsDGV).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel6;
        private Label label9;
        private Panel panel5;
        private Label label8;
        private Label userHeading;
        private Panel panel3;
        private Label accBalLbl;
        private Label label5;
        private Panel panel4;
        private Label warningLbl;
        private Label label7;
        private Panel panel2;
        private Label dayLbl;
        private Label dayHeadingLbl;
        private ComboBox comboBox1;
        private DataGridView transactionsDGV;
        private DataGridView budgetDGV;
        private Panel panel7;
        private Button transactB;
        private ComboBox budgFilterCB;
        private Label budgetInstructionLbl;
        private Panel panel8;
        private Button budgB;
        private Panel panel9;
        private Button logB;
    }
}