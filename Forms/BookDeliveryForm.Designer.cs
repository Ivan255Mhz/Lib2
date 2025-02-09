namespace Lib.Forms
{
    partial class BookDeliveryForm
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
            VisitorlistBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // VisitorlistBox
            // 
            VisitorlistBox.FormattingEnabled = true;
            VisitorlistBox.Location = new Point(7, 18);
            VisitorlistBox.Name = "VisitorlistBox";
            VisitorlistBox.Size = new Size(345, 384);
            VisitorlistBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(81, 408);
            button1.Name = "button1";
            button1.Size = new Size(180, 45);
            button1.TabIndex = 1;
            button1.Text = "Выдать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 463);
            Controls.Add(button1);
            Controls.Add(VisitorlistBox);
            Name = "BookDeliveryForm";
            Text = "BookDeliveryForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox VisitorlistBox;
        private Button button1;
    }
}