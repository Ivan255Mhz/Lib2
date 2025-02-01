namespace Lib.Forms
{
    partial class AdminForm
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
            AdminlistBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Exitbutton = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AdminlistBox);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 368);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Учетные записи:";
            // 
            // AdminlistBox
            // 
            AdminlistBox.FormattingEnabled = true;
            AdminlistBox.Location = new Point(6, 26);
            AdminlistBox.Name = "AdminlistBox";
            AdminlistBox.Size = new Size(764, 324);
            AdminlistBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(18, 403);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(138, 403);
            button2.Name = "button2";
            button2.Size = new Size(114, 35);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(258, 403);
            button3.Name = "button3";
            button3.Size = new Size(114, 35);
            button3.TabIndex = 3;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.Red;
            Exitbutton.Location = new Point(668, 403);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(114, 35);
            Exitbutton.TabIndex = 4;
            Exitbutton.Text = "Выход";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(470, 403);
            button5.Name = "button5";
            button5.Size = new Size(114, 35);
            button5.TabIndex = 5;
            button5.Text = "Импорт";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(470, 444);
            button6.Name = "button6";
            button6.Size = new Size(114, 35);
            button6.TabIndex = 6;
            button6.Text = "Экспорт";
            button6.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AccessibleRole = AccessibleRole.Clock;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(Exitbutton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "Администратор";
            Load += AdminForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox AdminlistBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Exitbutton;
        private Button button5;
        private Button button6;
    }
}