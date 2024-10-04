namespace ToDoListWinForms.Forms
{
    partial class RegistrationForm
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
            label2 = new Label();
            createEmailBox = new TextBox();
            label3 = new Label();
            createPasswordBox = new TextBox();
            label4 = new Label();
            repeatPasswordBox = new TextBox();
            createAccButton = new Button();
            BackToLoginForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // createEmailBox
            // 
            createEmailBox.Location = new Point(59, 106);
            createEmailBox.Name = "createEmailBox";
            createEmailBox.PlaceholderText = "example.mail@gmail.com";
            createEmailBox.Size = new Size(230, 23);
            createEmailBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(59, 132);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // createPasswordBox
            // 
            createPasswordBox.Location = new Point(59, 156);
            createPasswordBox.Name = "createPasswordBox";
            createPasswordBox.PasswordChar = '*';
            createPasswordBox.Size = new Size(230, 23);
            createPasswordBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(59, 182);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 5;
            label4.Text = "Repeat Password";
            // 
            // repeatPasswordBox
            // 
            repeatPasswordBox.Location = new Point(59, 206);
            repeatPasswordBox.Name = "repeatPasswordBox";
            repeatPasswordBox.PasswordChar = '*';
            repeatPasswordBox.Size = new Size(230, 23);
            repeatPasswordBox.TabIndex = 6;
            // 
            // createAccButton
            // 
            createAccButton.Location = new Point(59, 246);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(84, 38);
            createAccButton.TabIndex = 7;
            createAccButton.Text = "Create account";
            createAccButton.UseVisualStyleBackColor = true;
            createAccButton.Click += CreateAcc_Click;
            // 
            // BackToLoginForm
            // 
            BackToLoginForm.Location = new Point(214, 246);
            BackToLoginForm.Name = "BackToLoginForm";
            BackToLoginForm.Size = new Size(75, 38);
            BackToLoginForm.TabIndex = 8;
            BackToLoginForm.Text = "Login Form";
            BackToLoginForm.UseVisualStyleBackColor = true;
            BackToLoginForm.Click += BackToLoginForm_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 347);
            Controls.Add(BackToLoginForm);
            Controls.Add(createAccButton);
            Controls.Add(repeatPasswordBox);
            Controls.Add(label4);
            Controls.Add(createPasswordBox);
            Controls.Add(label3);
            Controls.Add(createEmailBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox createEmailBox;
        private Label label3;
        private TextBox createPasswordBox;
        private Label label4;
        private TextBox repeatPasswordBox;
        private Button createAccButton;
        private Button BackToLoginForm;
    }
}