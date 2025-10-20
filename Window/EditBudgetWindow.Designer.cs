namespace WindowFormsAssignment2.Window
{
    partial class EditBudgetWindow
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
            AmountSlider = new TrackBar();
            AmountLbl = new Label();
            CancelBtn = new Button();
            SaveBtn = new Button();
            BudgetNameLbl = new Label();
            colorDialog = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)AmountSlider).BeginInit();
            SuspendLayout();
            // 
            // AmountSlider
            // 
            AmountSlider.Location = new Point(52, 148);
            AmountSlider.Name = "AmountSlider";
            AmountSlider.Size = new Size(296, 45);
            AmountSlider.TabIndex = 0;
            // 
            // AmountLbl
            // 
            AmountLbl.AutoSize = true;
            AmountLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLbl.Location = new Point(52, 104);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(68, 17);
            AmountLbl.TabIndex = 8;
            AmountLbl.Text = "New Limit:";
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = SystemColors.ControlDarkDark;
            CancelBtn.Location = new Point(222, 210);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 34);
            CancelBtn.TabIndex = 10;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.Green;
            SaveBtn.Location = new Point(108, 210);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 34);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // BudgetNameLbl
            // 
            BudgetNameLbl.Dock = DockStyle.Top;
            BudgetNameLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BudgetNameLbl.Location = new Point(0, 0);
            BudgetNameLbl.Name = "BudgetNameLbl";
            BudgetNameLbl.Size = new Size(394, 94);
            BudgetNameLbl.TabIndex = 11;
            BudgetNameLbl.Text = "Budget:";
            BudgetNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditBudgetWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 291);
            Controls.Add(BudgetNameLbl);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(AmountLbl);
            Controls.Add(AmountSlider);
            Name = "EditBudgetWindow";
            Text = "EditBudgetWindow";
            ((System.ComponentModel.ISupportInitialize)AmountSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar AmountSlider;
        private Label AmountLbl;
        private Button CancelBtn;
        private Button SaveBtn;
        private Label BudgetNameLbl;
        private Button button1;
        private ColorDialog colorDialog;
    }
}