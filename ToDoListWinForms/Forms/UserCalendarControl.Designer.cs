namespace ToDoListWinForms.Forms
{
    partial class UserCalendarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            deleteTaskCalendarButton = new Button();
            editTaskCalendarButton = new Button();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(deleteTaskCalendarButton);
            panel1.Controls.Add(editTaskCalendarButton);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 138);
            panel1.TabIndex = 0;
            // 
            // deleteTaskCalendarButton
            // 
            deleteTaskCalendarButton.Location = new Point(49, 7);
            deleteTaskCalendarButton.Name = "deleteTaskCalendarButton";
            deleteTaskCalendarButton.Size = new Size(51, 23);
            deleteTaskCalendarButton.TabIndex = 6;
            deleteTaskCalendarButton.Text = "Delete";
            deleteTaskCalendarButton.UseVisualStyleBackColor = true;
            deleteTaskCalendarButton.Click += deleteTaskCalendarButton_Click;
            // 
            // editTaskCalendarButton
            // 
            editTaskCalendarButton.Location = new Point(3, 7);
            editTaskCalendarButton.Name = "editTaskCalendarButton";
            editTaskCalendarButton.Size = new Size(40, 23);
            editTaskCalendarButton.TabIndex = 5;
            editTaskCalendarButton.Text = "Edit";
            editTaskCalendarButton.UseVisualStyleBackColor = true;
            editTaskCalendarButton.Click += editTaskCalendarButton_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 35);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(156, 94);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 15);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // UserCalendarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserCalendarControl";
            Padding = new Padding(1);
            Size = new Size(167, 140);
            Load += UserCalendarControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button deleteTaskCalendarButton;
        private Button editTaskCalendarButton;
    }
}
