namespace WindowFormsAssignment2.Window
{
    partial class BudgetWindow
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
            TotalProgBar = new ProgressBar();
            OverallPanel = new Panel();
            NotInUseLbl = new Label();
            TotalRemainingLbl = new Label();
            TotalSpentLbl = new Label();
            TotalBudgetLbl = new Label();
            label2 = new Label();
            CategoriesPanel = new TableLayoutPanel();
            ProgressLbl = new Label();
            CategoryLbl = new Label();
            RemainingLbl = new Label();
            AllocatedLbl = new Label();
            SpentLbl = new Label();
            BottomPanel = new Panel();
            btnAddBudget = new Button();
            backBtn = new Button();
            OverallPanel.SuspendLayout();
            CategoriesPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TotalProgBar
            // 
            TotalProgBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TotalProgBar.Location = new Point(18, 81);
            TotalProgBar.Margin = new Padding(3, 4, 3, 4);
            TotalProgBar.Name = "TotalProgBar";
            TotalProgBar.Size = new Size(830, 31);
            TotalProgBar.TabIndex = 0;
            // 
            // OverallPanel
            // 
            OverallPanel.BackColor = SystemColors.ScrollBar;
            OverallPanel.BorderStyle = BorderStyle.FixedSingle;
            OverallPanel.Controls.Add(NotInUseLbl);
            OverallPanel.Controls.Add(TotalRemainingLbl);
            OverallPanel.Controls.Add(TotalSpentLbl);
            OverallPanel.Controls.Add(TotalBudgetLbl);
            OverallPanel.Controls.Add(TotalProgBar);
            OverallPanel.Dock = DockStyle.Top;
            OverallPanel.Location = new Point(0, 0);
            OverallPanel.Margin = new Padding(3, 4, 3, 4);
            OverallPanel.Name = "OverallPanel";
            OverallPanel.Size = new Size(862, 139);
            OverallPanel.TabIndex = 4;
            // 
            // NotInUseLbl
            // 
            NotInUseLbl.AutoSize = true;
            NotInUseLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotInUseLbl.ForeColor = Color.FromArgb(192, 0, 0);
            NotInUseLbl.Location = new Point(607, 23);
            NotInUseLbl.Name = "NotInUseLbl";
            NotInUseLbl.Padding = new Padding(0, 0, 0, 1);
            NotInUseLbl.Size = new Size(116, 26);
            NotInUseLbl.TabIndex = 15;
            NotInUseLbl.Text = "Not In Use: ";
            // 
            // TotalRemainingLbl
            // 
            TotalRemainingLbl.AutoSize = true;
            TotalRemainingLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalRemainingLbl.Location = new Point(403, 23);
            TotalRemainingLbl.Name = "TotalRemainingLbl";
            TotalRemainingLbl.Padding = new Padding(0, 0, 0, 1);
            TotalRemainingLbl.Size = new Size(117, 26);
            TotalRemainingLbl.TabIndex = 14;
            TotalRemainingLbl.Text = "Remaining: ";
            // 
            // TotalSpentLbl
            // 
            TotalSpentLbl.AutoSize = true;
            TotalSpentLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalSpentLbl.Location = new Point(241, 23);
            TotalSpentLbl.Name = "TotalSpentLbl";
            TotalSpentLbl.Padding = new Padding(0, 0, 0, 1);
            TotalSpentLbl.Size = new Size(74, 26);
            TotalSpentLbl.TabIndex = 13;
            TotalSpentLbl.Text = "Spent: ";
            // 
            // TotalBudgetLbl
            // 
            TotalBudgetLbl.AutoSize = true;
            TotalBudgetLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalBudgetLbl.Location = new Point(18, 23);
            TotalBudgetLbl.Name = "TotalBudgetLbl";
            TotalBudgetLbl.Padding = new Padding(0, 0, 0, 1);
            TotalBudgetLbl.Size = new Size(135, 26);
            TotalBudgetLbl.TabIndex = 12;
            TotalBudgetLbl.Text = "Total Budget: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 172);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // CategoriesPanel
            // 
            CategoriesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoriesPanel.AutoScroll = true;
            CategoriesPanel.BackColor = SystemColors.ButtonFace;
            CategoriesPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            CategoriesPanel.ColumnCount = 7;
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.51021F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7550993F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.779974F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.516469F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5101986F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.3571434F));
            CategoriesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.3571434F));
            CategoriesPanel.Controls.Add(ProgressLbl, 4, 0);
            CategoriesPanel.Controls.Add(CategoryLbl, 0, 0);
            CategoriesPanel.Controls.Add(RemainingLbl, 3, 0);
            CategoriesPanel.Controls.Add(AllocatedLbl, 1, 0);
            CategoriesPanel.Controls.Add(SpentLbl, 2, 0);
            CategoriesPanel.Location = new Point(0, 140);
            CategoriesPanel.Margin = new Padding(3, 4, 3, 4);
            CategoriesPanel.Name = "CategoriesPanel";
            CategoriesPanel.RowCount = 2;
            CategoriesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            CategoriesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            CategoriesPanel.Size = new Size(862, 341);
            CategoriesPanel.TabIndex = 14;
            // 
            // ProgressLbl
            // 
            ProgressLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProgressLbl.AutoSize = true;
            ProgressLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressLbl.Location = new Point(551, 1);
            ProgressLbl.Name = "ProgressLbl";
            ProgressLbl.Padding = new Padding(0, 0, 0, 1);
            ProgressLbl.Size = new Size(212, 47);
            ProgressLbl.TabIndex = 11;
            ProgressLbl.Text = "Progress";
            ProgressLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryLbl
            // 
            CategoryLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLbl.AutoSize = true;
            CategoryLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLbl.Location = new Point(4, 1);
            CategoryLbl.Name = "CategoryLbl";
            CategoryLbl.Padding = new Padding(0, 0, 0, 1);
            CategoryLbl.Size = new Size(212, 47);
            CategoryLbl.TabIndex = 7;
            CategoryLbl.Text = "Category";
            CategoryLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemainingLbl
            // 
            RemainingLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemainingLbl.AutoSize = true;
            RemainingLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemainingLbl.Location = new Point(443, 1);
            RemainingLbl.Name = "RemainingLbl";
            RemainingLbl.Padding = new Padding(0, 0, 0, 1);
            RemainingLbl.Size = new Size(101, 47);
            RemainingLbl.TabIndex = 10;
            RemainingLbl.Text = "Remaining";
            RemainingLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AllocatedLbl
            // 
            AllocatedLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllocatedLbl.AutoSize = true;
            AllocatedLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllocatedLbl.Location = new Point(223, 1);
            AllocatedLbl.Name = "AllocatedLbl";
            AllocatedLbl.Padding = new Padding(0, 0, 0, 1);
            AllocatedLbl.Size = new Size(103, 47);
            AllocatedLbl.TabIndex = 8;
            AllocatedLbl.Text = "Allocated";
            AllocatedLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpentLbl
            // 
            SpentLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SpentLbl.AutoSize = true;
            SpentLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpentLbl.Location = new Point(333, 1);
            SpentLbl.Name = "SpentLbl";
            SpentLbl.Padding = new Padding(0, 0, 0, 1);
            SpentLbl.Size = new Size(103, 47);
            SpentLbl.TabIndex = 9;
            SpentLbl.Text = "Spent";
            SpentLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.LightSlateGray;
            BottomPanel.Controls.Add(backBtn);
            BottomPanel.Controls.Add(btnAddBudget);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 482);
            BottomPanel.Margin = new Padding(3, 4, 3, 4);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(862, 133);
            BottomPanel.TabIndex = 15;
            // 
            // btnAddBudget
            // 
            btnAddBudget.Font = new Font("Segoe UI", 10F);
            btnAddBudget.Location = new Point(168, 60);
            btnAddBudget.Margin = new Padding(3, 4, 3, 4);
            btnAddBudget.Name = "btnAddBudget";
            btnAddBudget.Size = new Size(113, 48);
            btnAddBudget.TabIndex = 0;
            btnAddBudget.Text = "Add Budget";
            btnAddBudget.UseVisualStyleBackColor = true;
            btnAddBudget.Click += BtnAdd_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Segoe UI", 10F);
            backBtn.Location = new Point(28, 60);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(113, 48);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // BudgetWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(862, 615);
            Controls.Add(BottomPanel);
            Controls.Add(CategoriesPanel);
            Controls.Add(label2);
            Controls.Add(OverallPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetWindow";
            Text = "Budget";
            OverallPanel.ResumeLayout(false);
            OverallPanel.PerformLayout();
            CategoriesPanel.ResumeLayout(false);
            CategoriesPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar TotalProgBar;
        private Panel OverallPanel;
        private Label label2;
        private Label TotalBudgetLbl;
        private Label TotalSpentLbl;
        private Label TotalRemainingLbl;
        private Label NotInUseLbl;
        private TableLayoutPanel CategoriesPanel;
        private Label ProgressLbl;
        private Label CategoryLbl;
        private Label RemainingLbl;
        private Label AllocatedLbl;
        private Label SpentLbl;
        private Panel BottomPanel;
        private Button btnAddBudget;
        private Button backBtn;
    }
}