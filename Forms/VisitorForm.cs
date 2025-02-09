using Lib.Class;
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
            NametextBox.Text = visitor.name;
            UpdateTextBox();

        }

        private void BooklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
            else
            {
                BookTextBox.Clear();
            }
        }


    }
}
