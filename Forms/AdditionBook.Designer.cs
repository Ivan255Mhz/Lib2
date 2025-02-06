namespace Lib.Forms
{
    partial class AdditionBook
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
            label4 = new Label();
            NameTextBox = new TextBox();
            GenreTextBox = new TextBox();
            PublisherTextBox = new TextBox();
            PagesNumeric = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PagesNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Издатель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Страниц";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(95, 58);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(290, 27);
            NameTextBox.TabIndex = 4;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(95, 96);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(290, 27);
            GenreTextBox.TabIndex = 5;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Location = new Point(95, 133);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(290, 27);
            PublisherTextBox.TabIndex = 6;
            // 
            // PagesNumeric
            // 
            PagesNumeric.Location = new Point(95, 170);
            PagesNumeric.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            PagesNumeric.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            PagesNumeric.Name = "PagesNumeric";
            PagesNumeric.Size = new Size(125, 27);
            PagesNumeric.TabIndex = 7;
            PagesNumeric.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(95, 219);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(279, 219);
            button2.Name = "button2";
            button2.Size = new Size(106, 41);
            button2.TabIndex = 9;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdditionBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 313);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PagesNumeric);
            Controls.Add(PublisherTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdditionBook";
            Text = "AdditionBook";
            Load += AdditionBook_Load;
            ((System.ComponentModel.ISupportInitialize)PagesNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTextBox;
        private TextBox GenreTextBox;
        private TextBox PublisherTextBox;
        private NumericUpDown PagesNumeric;
        private Button button1;
        private Button button2;
    }
}