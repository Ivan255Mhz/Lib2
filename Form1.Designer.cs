namespace Lib
{
    partial class Form1
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
            button1 = new Button();
            Login_label = new Label();
            Password_label = new Label();
            Login_textBox = new TextBox();
            Password_textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(228, 199);
            button1.Name = "button1";
            button1.Size = new Size(121, 51);
            button1.TabIndex = 0;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login_label
            // 
            Login_label.AutoSize = true;
            Login_label.Location = new Point(76, 83);
            Login_label.Name = "Login_label";
            Login_label.Size = new Size(52, 20);
            Login_label.TabIndex = 1;
            Login_label.Text = "Логин";
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Location = new Point(76, 146);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(62, 20);
            Password_label.TabIndex = 2;
            Password_label.Text = "Пароль";
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(144, 83);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(306, 27);
            Login_textBox.TabIndex = 3;
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(144, 143);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PasswordChar = '*';
            Password_textBox.Size = new Size(306, 27);
            Password_textBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 321);
            Controls.Add(Password_textBox);
            Controls.Add(Login_textBox);
            Controls.Add(Password_label);
            Controls.Add(Login_label);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Login_label;
        private Label Password_label;
        private TextBox Login_textBox;
        private TextBox Password_textBox;
    }
}
