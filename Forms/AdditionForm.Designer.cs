namespace Lib.Forms
{
    partial class AdditionForm
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
            AddNameBox = new TextBox();
            AddLoginBox = new TextBox();
            AddPasswordBox = new TextBox();
            TypeComboBox = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // AddNameBox
            // 
            AddNameBox.Location = new Point(96, 44);
            AddNameBox.Name = "AddNameBox";
            AddNameBox.Size = new Size(258, 27);
            AddNameBox.TabIndex = 3;
            // 
            // AddLoginBox
            // 
            AddLoginBox.Location = new Point(96, 87);
            AddLoginBox.Name = "AddLoginBox";
            AddLoginBox.Size = new Size(258, 27);
            AddLoginBox.TabIndex = 4;
            // 
            // AddPasswordBox
            // 
            AddPasswordBox.Location = new Point(96, 130);
            AddPasswordBox.Name = "AddPasswordBox";
            AddPasswordBox.Size = new Size(258, 27);
            AddPasswordBox.TabIndex = 5;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Администратор", "Работник", "Пользователь" });
            TypeComboBox.Location = new Point(96, 203);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(258, 28);
            TypeComboBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 206);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Тип";
            // 
            // button1
            // 
            button1.Location = new Point(51, 288);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(217, 288);
            button2.Name = "button2";
            button2.Size = new Size(114, 46);
            button2.TabIndex = 9;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdditionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 433);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(TypeComboBox);
            Controls.Add(AddPasswordBox);
            Controls.Add(AddLoginBox);
            Controls.Add(AddNameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdditionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdditionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AddNameBox;
        private TextBox AddLoginBox;
        private TextBox AddPasswordBox;
        private ComboBox TypeComboBox;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}