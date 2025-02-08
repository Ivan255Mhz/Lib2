namespace Lib.Forms
{
    partial class SetBookForm
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
            BookGroupBox = new GroupBox();
            BooktextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            тексToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьТекстToolStripMenuItem = new ToolStripMenuItem();
            стильToolStripMenuItem = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            цветТекстаToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem1 = new ToolStripMenuItem();
            синийToolStripMenuItem1 = new ToolStripMenuItem();
            зеленыйToolStripMenuItem1 = new ToolStripMenuItem();
            стильТекстаToolStripMenuItem = new ToolStripMenuItem();
            segoeUIToolStripMenuItem = new ToolStripMenuItem();
            tahomaToolStripMenuItem = new ToolStripMenuItem();
            simSumToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            размерТекстаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            BookGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BookGroupBox
            // 
            BookGroupBox.Controls.Add(BooktextBox);
            BookGroupBox.Location = new Point(14, 36);
            BookGroupBox.Margin = new Padding(3, 4, 3, 4);
            BookGroupBox.Name = "BookGroupBox";
            BookGroupBox.Padding = new Padding(3, 4, 3, 4);
            BookGroupBox.Size = new Size(643, 515);
            BookGroupBox.TabIndex = 0;
            BookGroupBox.TabStop = false;
            BookGroupBox.Text = "groupBox1";
            // 
            // BooktextBox
            // 
            BooktextBox.Location = new Point(7, 29);
            BooktextBox.Margin = new Padding(3, 4, 3, 4);
            BooktextBox.Multiline = true;
            BooktextBox.Name = "BooktextBox";
            BooktextBox.ScrollBars = ScrollBars.Vertical;
            BooktextBox.Size = new Size(620, 463);
            BooktextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { тексToolStripMenuItem, стильToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(664, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // тексToolStripMenuItem
            // 
            тексToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, очиститьТекстToolStripMenuItem });
            тексToolStripMenuItem.Name = "тексToolStripMenuItem";
            тексToolStripMenuItem.Size = new Size(53, 24);
            тексToolStripMenuItem.Text = "Текс";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(194, 26);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // очиститьТекстToolStripMenuItem
            // 
            очиститьТекстToolStripMenuItem.Name = "очиститьТекстToolStripMenuItem";
            очиститьТекстToolStripMenuItem.Size = new Size(194, 26);
            очиститьТекстToolStripMenuItem.Text = "Очистить текст";
            очиститьТекстToolStripMenuItem.Click += очиститьТекстToolStripMenuItem_Click;
            // 
            // стильToolStripMenuItem
            // 
            стильToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветФонаToolStripMenuItem, цветТекстаToolStripMenuItem, стильТекстаToolStripMenuItem, размерТекстаToolStripMenuItem });
            стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            стильToolStripMenuItem.Size = new Size(63, 24);
            стильToolStripMenuItem.Text = "Стиль";
            стильToolStripMenuItem.Click += стильToolStripMenuItem_Click;
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem, синийToolStripMenuItem, зеленыйToolStripMenuItem });
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(224, 26);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(154, 26);
            красныйToolStripMenuItem.Text = "Красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(154, 26);
            синийToolStripMenuItem.Text = "Синий";
            синийToolStripMenuItem.Click += синийToolStripMenuItem_Click;
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(154, 26);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            зеленыйToolStripMenuItem.Click += зеленыйToolStripMenuItem_Click;
            // 
            // цветТекстаToolStripMenuItem
            // 
            цветТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem1, синийToolStripMenuItem1, зеленыйToolStripMenuItem1 });
            цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            цветТекстаToolStripMenuItem.Size = new Size(224, 26);
            цветТекстаToolStripMenuItem.Text = "Цвет текста";
            // 
            // красныйToolStripMenuItem1
            // 
            красныйToolStripMenuItem1.Name = "красныйToolStripMenuItem1";
            красныйToolStripMenuItem1.Size = new Size(154, 26);
            красныйToolStripMenuItem1.Text = "Красный";
            красныйToolStripMenuItem1.Click += красныйToolStripMenuItem1_Click;
            // 
            // синийToolStripMenuItem1
            // 
            синийToolStripMenuItem1.Name = "синийToolStripMenuItem1";
            синийToolStripMenuItem1.Size = new Size(154, 26);
            синийToolStripMenuItem1.Text = "Синий";
            синийToolStripMenuItem1.Click += синийToolStripMenuItem1_Click;
            // 
            // зеленыйToolStripMenuItem1
            // 
            зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            зеленыйToolStripMenuItem1.Size = new Size(154, 26);
            зеленыйToolStripMenuItem1.Text = "Зеленый";
            зеленыйToolStripMenuItem1.Click += зеленыйToolStripMenuItem1_Click;
            // 
            // стильТекстаToolStripMenuItem
            // 
            стильТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { segoeUIToolStripMenuItem, tahomaToolStripMenuItem, simSumToolStripMenuItem, timesNewRomanToolStripMenuItem });
            стильТекстаToolStripMenuItem.Name = "стильТекстаToolStripMenuItem";
            стильТекстаToolStripMenuItem.Size = new Size(224, 26);
            стильТекстаToolStripMenuItem.Text = "Стиль текста";
            // 
            // segoeUIToolStripMenuItem
            // 
            segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            segoeUIToolStripMenuItem.Size = new Size(216, 26);
            segoeUIToolStripMenuItem.Text = "Segoe UI";
            segoeUIToolStripMenuItem.Click += segoeUIToolStripMenuItem_Click;
            // 
            // tahomaToolStripMenuItem
            // 
            tahomaToolStripMenuItem.Name = "tahomaToolStripMenuItem";
            tahomaToolStripMenuItem.Size = new Size(216, 26);
            tahomaToolStripMenuItem.Text = "Tahoma";
            tahomaToolStripMenuItem.Click += tahomaToolStripMenuItem_Click;
            // 
            // simSumToolStripMenuItem
            // 
            simSumToolStripMenuItem.Name = "simSumToolStripMenuItem";
            simSumToolStripMenuItem.Size = new Size(216, 26);
            simSumToolStripMenuItem.Text = "SimSum";
            simSumToolStripMenuItem.Click += simSumToolStripMenuItem_Click;
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(216, 26);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
            // 
            // размерТекстаToolStripMenuItem
            // 
            размерТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            размерТекстаToolStripMenuItem.Name = "размерТекстаToolStripMenuItem";
            размерТекстаToolStripMenuItem.Size = new Size(224, 26);
            размерТекстаToolStripMenuItem.Text = "Размер текста";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "9";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(224, 26);
            toolStripMenuItem3.Text = "10";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(224, 26);
            toolStripMenuItem4.Text = "11";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(224, 26);
            toolStripMenuItem5.Text = "12";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(310, 559);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 2;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 559);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(106, 49);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SetBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 613);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BookGroupBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SetBookForm";
            Text = "SetBookForm";
            Load += SetBookForm_Load;
            BookGroupBox.ResumeLayout(false);
            BookGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox BookGroupBox;
        private TextBox BooktextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem тексToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem очиститьТекстToolStripMenuItem;
        private ToolStripMenuItem стильToolStripMenuItem;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private ToolStripMenuItem цветТекстаToolStripMenuItem;
        private ToolStripMenuItem стильТекстаToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem1;
        private ToolStripMenuItem синийToolStripMenuItem1;
        private ToolStripMenuItem зеленыйToolStripMenuItem1;
        private ToolStripMenuItem размерТекстаToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem segoeUIToolStripMenuItem;
        private ToolStripMenuItem tahomaToolStripMenuItem;
        private ToolStripMenuItem simSumToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
    }
}