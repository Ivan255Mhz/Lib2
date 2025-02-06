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
    public partial class AdditionBook : Form
    {

        public WorkerForm _workerForm;

        public bool _addEdit;
        public AdditionBook()
        {
            InitializeComponent();
        }

        public AdditionBook(WorkerForm workerForm, bool AddEdit)
        {
            InitializeComponent();
            _workerForm = workerForm;
            _addEdit = AddEdit;
            this.FormClosed += (s, args) => _workerForm.Show();
            if (AddEdit)
            {
                this.Text = "Добавить книгу ";
            }
            else
            {
                this.Text = "Изменить книгу";
                button1.Text = "Изменить";
                NameTextBox.Text = _workerForm.SelectedUser.name;
                GenreTextBox.Text = _workerForm.SelectedUser.genre;
                PublisherTextBox.Text = _workerForm.SelectedUser.publisher;
                PagesNumeric.Value = _workerForm.SelectedUser.pages;

            }
        }

        private void AdditionBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = _workerForm.SelectedUser.name;
            string Genre = _workerForm.SelectedUser.genre;
            int Pages = _workerForm.SelectedUser.pages;
            string Publisher = _workerForm.SelectedUser.publisher;

            if(Name==string.Empty||Genre==string.Empty||Publisher==string.Empty)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_addEdit)
            {
                BookDataBase.AddBook(new Book(Name,Pages,Genre,Publisher));
                _workerForm.UpdateListBox();
                this.Close();
            }
            else
            {
                BookDataBase.EditBook(_workerForm.SelectedUser,Name,Pages,Genre,Publisher);
                _workerForm.UpdateListBox();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            GenreTextBox.Text = string.Empty ;
            PublisherTextBox.Text = string .Empty ;
            
        
        }
    }
}
