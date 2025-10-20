namespace WindowFormsAssignment2.Window
{
    partial class LoginWindow
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
            userTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            signUpB = new Button();
            passTB = new MaskedTextBox();
            loginB = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // userTB
            // 
            userTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTB.Location = new Point(366, 231);
            userTB.Name = "userTB";
            userTB.Size = new Size(233, 27);
            userTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(245, 231);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(251, 293);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // signUpB
            // 
            signUpB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signUpB.Location = new Point(422, 350);
            signUpB.Name = "signUpB";
            signUpB.Size = new Size(177, 29);
            signUpB.TabIndex = 5;
            signUpB.Text = "Sign up";
            signUpB.UseVisualStyleBackColor = true;
            signUpB.Click += signUpButton_Click;
            // 
            // passTB
            // 
            passTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passTB.Location = new Point(366, 293);
            passTB.Name = "passTB";
            passTB.PasswordChar = '*';
            passTB.Size = new Size(233, 27);
            passTB.TabIndex = 6;
            passTB.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // loginB
            // 
            loginB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginB.Location = new Point(245, 350);
            loginB.Name = "loginB";
            loginB.Size = new Size(171, 29);
            loginB.TabIndex = 7;
            loginB.Text = "Login";
            loginB.UseVisualStyleBackColor = true;
            loginB.Click += loginB_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(29, 134);
            label3.Name = "label3";
            label3.Size = new Size(744, 54);
            label3.TabIndex = 8;
            label3.Text = "Welcome to the Personal Finance Tracker";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(loginB);
            Controls.Add(passTB);
            Controls.Add(signUpB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userTB);
            Name = "LoginWindow";
            Text = "LoginForm";
            Load += LoginWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userTB;
        private Label label1;
        private Label label2;
        private Button signUpB;
        private MaskedTextBox passTB;
        private Button loginB;
        private Label label3;

        //validate users if user is not valid then throw an error
    }
}