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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lib.Forms
{
    public partial class WorkerForm : Form
    {

        public Form1 _form1;
       

        public WorkerForm(Form1 form1)
        {
            InitializeComponent();
            WorkerListBox.DataSource = BookDataBase.GetBookBase();

            this._form1 = form1;
            this.FormClosed += (s, args) => _form1.Show();

        }

        public void UpdateListBox()
        {
            WorkerListBox.DataSource = null;
            WorkerListBox.DataSource = BookDataBase.GetBookBase();
        }

        public List<Visitor> VisitorsOnly()
        {
            List<User> allUsers = UserDataBase.UserBase;
            var  visitorsOnly = allUsers.Where(user => user is Visitor).Cast<Visitor>().ToList();
            return visitorsOnly;
        }

        public Book SelectedUser => WorkerListBox.SelectedItem as Book;

        private void WorkerForm_Load(object sender, EventArgs e)
        {
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var additionBook = new AdditionBook(this, true);
            additionBook.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var additionBook = new AdditionBook(this, false);
            additionBook.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookDataBase.DeleteBook(WorkerListBox.SelectedItem as Book);
            this.UpdateListBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetBookForm setBookForm = new SetBookForm(this);
            setBookForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookDeliveryForm bookDeliveryForm = new BookDeliveryForm(this);
            bookDeliveryForm.Show();
            this.Hide();
        }
    }
}
