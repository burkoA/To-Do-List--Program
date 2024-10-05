namespace ToDoListWinForms.Forms
{
    partial class CreateForm
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
            label3 = new Label();
            taskTextBox = new TextBox();
            saveCreateButton = new Button();
            closeButton = new Button();
            dateTextBox = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 37);
            label1.TabIndex = 0;
            label1.Text = "Create Task Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(181, 71);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 3;
            label3.Text = "Task Description";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(181, 95);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(153, 23);
            taskTextBox.TabIndex = 4;
            // 
            // saveCreateButton
            // 
            saveCreateButton.Location = new Point(79, 143);
            saveCreateButton.Name = "saveCreateButton";
            saveCreateButton.Size = new Size(75, 23);
            saveCreateButton.TabIndex = 5;
            saveCreateButton.Text = "Save";
            saveCreateButton.UseVisualStyleBackColor = true;
            saveCreateButton.Click += SaveCreateButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(181, 143);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 6;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(12, 95);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(142, 23);
            dateTextBox.TabIndex = 7;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 330);
            Controls.Add(dateTextBox);
            Controls.Add(closeButton);
            Controls.Add(saveCreateButton);
            Controls.Add(taskTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateForm";
            Text = "Create Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox taskTextBox;
        private Button saveCreateButton;
        private Button closeButton;
        private DateTimePicker dateTextBox;
    }
}