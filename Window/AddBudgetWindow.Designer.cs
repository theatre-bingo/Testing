namespace WindowFormsAssignment2.Window
{
    partial class AddBudgetWindow
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
            AddBtn = new Button();
            CancelBtn = new Button();
            CatComboBox = new ComboBox();
            AmountSlider = new TrackBar();
            InfoLbl = new Label();
            AmountLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountSlider).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Green;
            AddBtn.Location = new Point(120, 223);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 34);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = SystemColors.ControlDarkDark;
            CancelBtn.Location = new Point(234, 223);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 34);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // CatComboBox
            // 
            CatComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatComboBox.FormattingEnabled = true;
            CatComboBox.Location = new Point(133, 82);
            CatComboBox.Name = "CatComboBox";
            CatComboBox.Size = new Size(153, 29);
            CatComboBox.TabIndex = 2;
            // 
            // AmountSlider
            // 
            AmountSlider.Location = new Point(55, 172);
            AmountSlider.Name = "AmountSlider";
            AmountSlider.Size = new Size(307, 56);
            AmountSlider.TabIndex = 3;
            // 
            // InfoLbl
            // 
            InfoLbl.AutoSize = true;
            InfoLbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoLbl.Location = new Point(46, 41);
            InfoLbl.Name = "InfoLbl";
            InfoLbl.Size = new Size(395, 25);
            InfoLbl.TabIndex = 4;
            InfoLbl.Text = "Select a budget category or enter a new one:";
            // 
            // AmountLbl
            // 
            AmountLbl.AutoSize = true;
            AmountLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLbl.Location = new Point(70, 134);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(76, 23);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AddBudgetWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 319);
            Controls.Add(AmountLbl);
            Controls.Add(InfoLbl);
            Controls.Add(AmountSlider);
            Controls.Add(CatComboBox);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddBudgetWindow";
            Text = "AddBudgetWindow";
            ((System.ComponentModel.ISupportInitialize)AmountSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Button CancelBtn;
        private ComboBox CatComboBox;
        private TrackBar AmountSlider;
        private Label InfoLbl;
        private Label AmountLbl;
    }
}