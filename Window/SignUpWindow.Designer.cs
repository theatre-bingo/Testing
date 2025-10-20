namespace WindowFormsAssignment2.Window
{
    partial class SignUpWindow
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            lNameTB = new TextBox();
            label2 = new Label();
            fNameTB = new TextBox();
            emailTB = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            passTB = new TextBox();
            panel3 = new Panel();
            timePeriodTypeLB = new ListBox();
            timePeriodNUD = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            budgTB = new TextBox();
            createAccB = new Button();
            exitB = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timePeriodNUD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 130);
            label1.TabIndex = 0;
            label1.Text = "Create New Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 130);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lNameTB);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(fNameTB);
            panel2.Location = new Point(12, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 105);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 59);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // lNameTB
            // 
            lNameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lNameTB.Location = new Point(133, 59);
            lNameTB.Name = "lNameTB";
            lNameTB.Size = new Size(279, 27);
            lNameTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 22);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // fNameTB
            // 
            fNameTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fNameTB.Location = new Point(133, 19);
            fNameTB.Name = "fNameTB";
            fNameTB.Size = new Size(279, 27);
            fNameTB.TabIndex = 0;
            // 
            // emailTB
            // 
            emailTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailTB.Location = new Point(133, 8);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(279, 27);
            emailTB.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 8);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(emailTB);
            panel5.Location = new Point(12, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(427, 43);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(passTB);
            panel6.Location = new Point(12, 272);
            panel6.Name = "panel6";
            panel6.Size = new Size(427, 43);
            panel6.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 8);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 1;
            label4.Text = "Create Password";
            // 
            // passTB
            // 
            passTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passTB.Location = new Point(133, 8);
            passTB.Name = "passTB";
            passTB.Size = new Size(279, 27);
            passTB.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(timePeriodTypeLB);
            panel3.Controls.Add(timePeriodNUD);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(budgTB);
            panel3.Location = new Point(445, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 180);
            panel3.TabIndex = 4;
            // 
            // timePeriodTypeLB
            // 
            timePeriodTypeLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timePeriodTypeLB.FormattingEnabled = true;
            timePeriodTypeLB.Items.AddRange(new object[] { "Days", "Weeks" });
            timePeriodTypeLB.Location = new Point(181, 145);
            timePeriodTypeLB.Name = "timePeriodTypeLB";
            timePeriodTypeLB.Size = new Size(135, 24);
            timePeriodTypeLB.TabIndex = 9;
            // 
            // timePeriodNUD
            // 
            timePeriodNUD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timePeriodNUD.Location = new Point(103, 145);
            timePeriodNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            timePeriodNUD.Name = "timePeriodNUD";
            timePeriodNUD.Size = new Size(72, 27);
            timePeriodNUD.TabIndex = 7;
            timePeriodNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 145);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 3;
            label6.Text = "Time Period";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 62);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 1;
            label7.Text = "Total Budget";
            // 
            // budgTB
            // 
            budgTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            budgTB.Location = new Point(103, 62);
            budgTB.Name = "budgTB";
            budgTB.Size = new Size(213, 27);
            budgTB.TabIndex = 0;
            // 
            // createAccB
            // 
            createAccB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createAccB.Location = new Point(256, 354);
            createAccB.Name = "createAccB";
            createAccB.Size = new Size(168, 29);
            createAccB.TabIndex = 7;
            createAccB.Text = "Create new account";
            createAccB.UseVisualStyleBackColor = true;
            createAccB.Click += createAccB_Click;
            // 
            // exitB
            // 
            exitB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitB.Location = new Point(145, 354);
            exitB.Name = "exitB";
            exitB.Size = new Size(105, 29);
            exitB.TabIndex = 8;
            exitB.Text = "Exit";
            exitB.UseVisualStyleBackColor = true;
            exitB.Click += exitB_Click;
            // 
            // SignUpWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitB);
            Controls.Add(createAccB);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUpWindow";
            Text = "SignUpWindow";
            Load += SignUpWindow_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timePeriodNUD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox lNameTB;
        private Label label2;
        private TextBox fNameTB;
        private TextBox emailTB;
        private Label label5;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private TextBox passTB;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private TextBox budgTB;
        private NumericUpDown timePeriodNUD;
        private Button createAccB;
        private Button exitB;
        private ListBox timePeriodTypeLB;
    }
}