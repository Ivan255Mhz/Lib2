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
            BookGroupBox.Location = new Point(12, 27);
            BookGroupBox.Name = "BookGroupBox";
            BookGroupBox.Size = new Size(563, 386);
            BookGroupBox.TabIndex = 0;
            BookGroupBox.TabStop = false;
            BookGroupBox.Text = "groupBox1";
            // 
            // BooktextBox
            // 
            BooktextBox.Location = new Point(6, 22);
            BooktextBox.Multiline = true;
            BooktextBox.Name = "BooktextBox";
            BooktextBox.ScrollBars = ScrollBars.Vertical;
            BooktextBox.Size = new Size(543, 348);
            BooktextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { тексToolStripMenuItem, стильToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(581, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // тексToolStripMenuItem
            // 
            тексToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, очиститьТекстToolStripMenuItem });
            тексToolStripMenuItem.Name = "тексToolStripMenuItem";
            тексToolStripMenuItem.Size = new Size(43, 20);
            тексToolStripMenuItem.Text = "Текс";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(157, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // очиститьТекстToolStripMenuItem
            // 
            очиститьТекстToolStripMenuItem.Name = "очиститьТекстToolStripMenuItem";
            очиститьТекстToolStripMenuItem.Size = new Size(157, 22);
            очиститьТекстToolStripMenuItem.Text = "Очистить текст";
            очиститьТекстToolStripMenuItem.Click += очиститьТекстToolStripMenuItem_Click;
            // 
            // стильToolStripMenuItem
            // 
            стильToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветФонаToolStripMenuItem, цветТекстаToolStripMenuItem, стильТекстаToolStripMenuItem, размерТекстаToolStripMenuItem });
            стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            стильToolStripMenuItem.Size = new Size(52, 20);
            стильToolStripMenuItem.Text = "Стиль";
            стильToolStripMenuItem.Click += стильToolStripMenuItem_Click;
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem, синийToolStripMenuItem, зеленыйToolStripMenuItem });
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(180, 22);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(123, 22);
            красныйToolStripMenuItem.Text = "Красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(123, 22);
            синийToolStripMenuItem.Text = "Синий";
            синийToolStripMenuItem.Click += синийToolStripMenuItem_Click;
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(123, 22);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            зеленыйToolStripMenuItem.Click += зеленыйToolStripMenuItem_Click;
            // 
            // цветТекстаToolStripMenuItem
            // 
            цветТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { красныйToolStripMenuItem1, синийToolStripMenuItem1, зеленыйToolStripMenuItem1 });
            цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            цветТекстаToolStripMenuItem.Size = new Size(180, 22);
            цветТекстаToolStripMenuItem.Text = "Цвет текста";
            // 
            // красныйToolStripMenuItem1
            // 
            красныйToolStripMenuItem1.Name = "красныйToolStripMenuItem1";
            красныйToolStripMenuItem1.Size = new Size(180, 22);
            красныйToolStripMenuItem1.Text = "Красный";
            красныйToolStripMenuItem1.Click += красныйToolStripMenuItem1_Click;
            // 
            // синийToolStripMenuItem1
            // 
            синийToolStripMenuItem1.Name = "синийToolStripMenuItem1";
            синийToolStripMenuItem1.Size = new Size(180, 22);
            синийToolStripMenuItem1.Text = "Синий";
            синийToolStripMenuItem1.Click += синийToolStripMenuItem1_Click;
            // 
            // зеленыйToolStripMenuItem1
            // 
            зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            зеленыйToolStripMenuItem1.Size = new Size(180, 22);
            зеленыйToolStripMenuItem1.Text = "Зеленый";
            зеленыйToolStripMenuItem1.Click += зеленыйToolStripMenuItem1_Click;
            // 
            // стильТекстаToolStripMenuItem
            // 
            стильТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { segoeUIToolStripMenuItem, tahomaToolStripMenuItem, simSumToolStripMenuItem, timesNewRomanToolStripMenuItem });
            стильТекстаToolStripMenuItem.Name = "стильТекстаToolStripMenuItem";
            стильТекстаToolStripMenuItem.Size = new Size(180, 22);
            стильТекстаToolStripMenuItem.Text = "Стиль текста";
            // 
            // segoeUIToolStripMenuItem
            // 
            segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            segoeUIToolStripMenuItem.Size = new Size(173, 22);
            segoeUIToolStripMenuItem.Text = "Segoe UI";
            // 
            // tahomaToolStripMenuItem
            // 
            tahomaToolStripMenuItem.Name = "tahomaToolStripMenuItem";
            tahomaToolStripMenuItem.Size = new Size(173, 22);
            tahomaToolStripMenuItem.Text = "Tahoma";
            // 
            // simSumToolStripMenuItem
            // 
            simSumToolStripMenuItem.Name = "simSumToolStripMenuItem";
            simSumToolStripMenuItem.Size = new Size(173, 22);
            simSumToolStripMenuItem.Text = "SimSum";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(173, 22);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            // 
            // размерТекстаToolStripMenuItem
            // 
            размерТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            размерТекстаToolStripMenuItem.Name = "размерТекстаToolStripMenuItem";
            размерТекстаToolStripMenuItem.Size = new Size(180, 22);
            размерТекстаToolStripMenuItem.Text = "Размер текста";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(86, 22);
            toolStripMenuItem2.Text = "9";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(86, 22);
            toolStripMenuItem3.Text = "10";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(86, 22);
            toolStripMenuItem4.Text = "11";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(86, 22);
            toolStripMenuItem5.Text = "12";
            // 
            // button1
            // 
            button1.Location = new Point(271, 419);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 2;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(163, 419);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SetBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 460);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BookGroupBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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