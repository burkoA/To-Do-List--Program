namespace ToDoListWinForms
{
    partial class TaskListView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createJson = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            taskListBox = new CheckedListBox();
            saveButton = new Button();
            label3 = new Label();
            deleteButton = new Button();
            addTaskButton = new Button();
            editTaskButton = new Button();
            userEmail = new Label();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // createJson
            // 
            createJson.DoWork += CreateJson_DoWork;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Task List";
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.HorizontalScrollbar = true;
            taskListBox.Location = new Point(12, 70);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(372, 202);
            taskListBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 291);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(304, 15);
            label3.TabIndex = 5;
            label3.Text = "Format: Complete/Uncomplete - Date - Task Description";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(93, 291);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(174, 291);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(75, 23);
            addTaskButton.TabIndex = 7;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTaskButton_Click;
            // 
            // editTaskButton
            // 
            editTaskButton.Location = new Point(255, 291);
            editTaskButton.Name = "editTaskButton";
            editTaskButton.Size = new Size(75, 23);
            editTaskButton.TabIndex = 8;
            editTaskButton.Text = "Edit Task";
            editTaskButton.UseVisualStyleBackColor = true;
            editTaskButton.Click += EditTaskButton_Click;
            // 
            // userEmail
            // 
            userEmail.AutoSize = true;
            userEmail.Location = new Point(235, 20);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(75, 15);
            userEmail.TabIndex = 9;
            userEmail.Text = "SetUserEmail";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(289, 407);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // TaskListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(logoutButton);
            Controls.Add(userEmail);
            Controls.Add(editTaskButton);
            Controls.Add(addTaskButton);
            Controls.Add(deleteButton);
            Controls.Add(label3);
            Controls.Add(saveButton);
            Controls.Add(taskListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaskListView";
            Text = "To-Do List Program";
            Load += TaskListView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker createJson;
        private Label label1;
        private Label label2;
        private CheckedListBox taskListBox;
        private Button saveButton;
        private Label label3;
        private Button deleteButton;
        private Button addTaskButton;
        private Button editTaskButton;
        private Label userEmail;
        private Button logoutButton;
    }
}
