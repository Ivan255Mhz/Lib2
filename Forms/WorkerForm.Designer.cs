namespace Lib.Forms
{
    partial class WorkerForm
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            WorkerListBox = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(WorkerListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги";
            // 
            // button3
            // 
            button3.Location = new Point(556, 294);
            button3.Name = "button3";
            button3.Size = new Size(122, 39);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 94);
            button2.Name = "button2";
            button2.Size = new Size(122, 39);
            button2.TabIndex = 2;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(556, 39);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 1;
            button1.Text = "Добить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WorkerListBox
            // 
            WorkerListBox.FormattingEnabled = true;
            WorkerListBox.Location = new Point(6, 29);
            WorkerListBox.Name = "WorkerListBox";
            WorkerListBox.Size = new Size(544, 304);
            WorkerListBox.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(21, 367);
            button4.Name = "button4";
            button4.Size = new Size(124, 54);
            button4.TabIndex = 1;
            button4.Text = "Импорт";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(151, 367);
            button5.Name = "button5";
            button5.Size = new Size(124, 54);
            button5.TabIndex = 2;
            button5.Text = "Экспорт";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(438, 367);
            button6.Name = "button6";
            button6.Size = new Size(124, 54);
            button6.TabIndex = 3;
            button6.Text = "Выдать Книгу";
            button6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 433);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 472);
            Controls.Add(dateTimePicker1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Name = "WorkerForm";
            Text = "WorkerForm";
            Load += WorkerForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox WorkerListBox;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private DateTimePicker dateTimePicker1;
    }
}