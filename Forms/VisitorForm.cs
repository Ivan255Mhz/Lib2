using Lib.Class;
using Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Forms
{
    public partial class VisitorForm : Form
    {
        public Form1 _form1;
        public VisitorForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += (s, args) => _form1.Show();
            Visitor visitor = (Visitor)_form1.User;
            BooklistBox.DataSource = visitor.userBooks;
            BooklistBox.DisplayMember = nameof(Book.name);
            BooklistBox.SelectedIndexChanged += BooklistBox_SelectedIndexChanged;
            numericFond.ValueChanged += NumericUpDown1_ValueChanged;
            NametextBox.Text = visitor.name;
            UpdateTextBox();

        }

        private void BooklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var selectedBook = BooklistBox.SelectedItem as Book;

            selectedBook.Font = new Font(selectedBook.Font.FontFamily.Name, (int)numericFond.Value);
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            var selectedBook = BooklistBox.SelectedItem as Book;
            if (selectedBook != null)
            {
                BookTextBox.Text = selectedBook.text;
                BookTextBox.BackColor = selectedBook.BackColor;
                BookTextBox.ForeColor = selectedBook.TextColor;
                BookTextBox.Font = selectedBook.Font;
                numericFond.Value = (decimal)selectedBook.Font.Size;
            }
            else
            {
                BookTextBox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor visitor = (Visitor)_form1.User;
            var selectedBook = BooklistBox.SelectedItem as Book;
            BookDataBase.books.Add(selectedBook);
            visitor.userBooks.Remove(selectedBook);
            UpdateTextBox();
            this.Close();

        }
    }
}
