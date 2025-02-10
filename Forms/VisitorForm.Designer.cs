namespace Lib.Forms
{
    partial class VisitorForm
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
            BooklistBox = new ListBox();
            groupBox2 = new GroupBox();
            BookTextBox = new TextBox();
            label1 = new Label();
            NametextBox = new TextBox();
            label2 = new Label();
            numericFond = new NumericUpDown();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFond).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BooklistBox);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги на руках";
            // 
            // BooklistBox
            // 
            BooklistBox.FormattingEnabled = true;
            BooklistBox.Location = new Point(0, 39);
            BooklistBox.Name = "BooklistBox";
            BooklistBox.Size = new Size(196, 404);
            BooklistBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BookTextBox);
            groupBox2.Location = new Point(220, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 447);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Текст";
            // 
            // BookTextBox
            // 
            BookTextBox.Location = new Point(6, 39);
            BookTextBox.Multiline = true;
            BookTextBox.Name = "BookTextBox";
            BookTextBox.Size = new Size(422, 400);
            BookTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Пользователь";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(125, 24);
            NametextBox.Name = "NametextBox";
            NametextBox.ReadOnly = true;
            NametextBox.Size = new Size(169, 27);
            NametextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 27);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Шрифт";
            // 
            // numericFond
            // 
            numericFond.Location = new Point(446, 25);
            numericFond.Name = "numericFond";
            numericFond.Size = new Size(106, 27);
            numericFond.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(18, 538);
            button1.Name = "button1";
            button1.Size = new Size(190, 39);
            button1.TabIndex = 6;
            button1.Text = "Вернкть книгу ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VisitorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 597);
            Controls.Add(button1);
            Controls.Add(numericFond);
            Controls.Add(label2);
            Controls.Add(NametextBox);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VisitorForm";
            Text = "VisitorForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox NametextBox;
        private Label label2;
        private NumericUpDown numericFond;
        private TextBox BookTextBox;
        private ListBox BooklistBox;
        private Button button1;
    }
}