namespace ToDoListWinForms.Forms
{
    partial class EditForm
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
            editTaskBox = new TextBox();
            SaveEditButton = new Button();
            EditCloseButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 0;
            label1.Text = "Edit Task Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 1;
            label2.Text = "Date - mm/dd/yy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(160, 78);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 2;
            label3.Text = "Task Description";
            // 
            // editTaskBox
            // 
            editTaskBox.Location = new Point(160, 102);
            editTaskBox.Name = "editTaskBox";
            editTaskBox.Size = new Size(167, 23);
            editTaskBox.TabIndex = 4;
            // 
            // SaveEditButton
            // 
            SaveEditButton.Location = new Point(67, 163);
            SaveEditButton.Name = "SaveEditButton";
            SaveEditButton.Size = new Size(75, 23);
            SaveEditButton.TabIndex = 5;
            SaveEditButton.Text = "Save";
            SaveEditButton.UseVisualStyleBackColor = true;
            SaveEditButton.Click += SaveEditButton_Click;
            // 
            // EditCloseButton
            // 
            EditCloseButton.Location = new Point(160, 163);
            EditCloseButton.Name = "EditCloseButton";
            EditCloseButton.Size = new Size(75, 23);
            EditCloseButton.TabIndex = 6;
            EditCloseButton.Text = "Close";
            EditCloseButton.UseVisualStyleBackColor = true;
            EditCloseButton.Click += EditCloseButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 240);
            Controls.Add(dateTimePicker1);
            Controls.Add(EditCloseButton);
            Controls.Add(SaveEditButton);
            Controls.Add(editTaskBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox editTaskBox;
        private Button SaveEditButton;
        private Button EditCloseButton;
        private DateTimePicker dateTimePicker1;
    }
}