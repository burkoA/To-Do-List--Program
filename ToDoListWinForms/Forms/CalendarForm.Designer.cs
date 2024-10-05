namespace ToDoListWinForms.Forms
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbMonth = new Label();
            buttonPreviousMonth = new PictureBox();
            buttonNextMonth = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)buttonPreviousMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonNextMonth).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 153);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1225, 734);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(114, 39);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label2.Location = new Point(184, 111);
            label2.Name = "label2";
            label2.Size = new Size(123, 39);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label3.Location = new Point(363, 111);
            label3.Name = "label3";
            label3.Size = new Size(127, 39);
            label3.TabIndex = 3;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label4.Location = new Point(522, 111);
            label4.Name = "label4";
            label4.Size = new Size(168, 39);
            label4.TabIndex = 4;
            label4.Text = "Wednesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label5.Location = new Point(713, 111);
            label5.Name = "label5";
            label5.Size = new Size(143, 39);
            label5.TabIndex = 5;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label6.Location = new Point(888, 111);
            label6.Name = "label6";
            label6.Size = new Size(104, 39);
            label6.TabIndex = 6;
            label6.Text = "Friday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 20F, FontStyle.Bold);
            label7.Location = new Point(1043, 111);
            label7.Name = "label7";
            label7.Size = new Size(136, 39);
            label7.TabIndex = 7;
            label7.Text = "Saturday";
            // 
            // lbMonth
            // 
            lbMonth.AutoSize = true;
            lbMonth.Font = new Font("Segoe UI", 25F);
            lbMonth.Location = new Point(12, 21);
            lbMonth.Name = "lbMonth";
            lbMonth.Size = new Size(144, 46);
            lbMonth.TabIndex = 8;
            lbMonth.Text = "MONTH";
            // 
            // buttonPreviousMonth
            // 
            buttonPreviousMonth.Image = (Image)resources.GetObject("buttonPreviousMonth.Image");
            buttonPreviousMonth.Location = new Point(363, 26);
            buttonPreviousMonth.Name = "buttonPreviousMonth";
            buttonPreviousMonth.Size = new Size(41, 41);
            buttonPreviousMonth.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonPreviousMonth.TabIndex = 9;
            buttonPreviousMonth.TabStop = false;
            buttonPreviousMonth.Click += buttonPreviousMonth_Click;
            // 
            // buttonNextMonth
            // 
            buttonNextMonth.Image = (Image)resources.GetObject("buttonNextMonth.Image");
            buttonNextMonth.Location = new Point(410, 26);
            buttonNextMonth.Name = "buttonNextMonth";
            buttonNextMonth.Size = new Size(41, 41);
            buttonNextMonth.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonNextMonth.TabIndex = 10;
            buttonNextMonth.TabStop = false;
            buttonNextMonth.Click += buttonNextMonth_Click;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 899);
            Controls.Add(buttonNextMonth);
            Controls.Add(buttonPreviousMonth);
            Controls.Add(lbMonth);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalendarForm";
            Text = "Calendar Form";
            Load += CalendarForm_Load;
            ((System.ComponentModel.ISupportInitialize)buttonPreviousMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonNextMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbMonth;
        private PictureBox buttonPreviousMonth;
        private PictureBox buttonNextMonth;
    }
}