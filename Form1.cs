using Lib.Class;
using Lib.Class;
using Lib.Data;
using Lib.Forms;

namespace Lib
{
    public partial class Form1 : Form
    {
        public User User { get; set; }

        private  const string userJson = "user.json";

        private  const string bookJson = "book.json";

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => JsonSaveLoadData.SaveDataUser(userJson, UserDataBase.GetUserBase());
            this.FormClosed += (s, args) => JsonSaveLoadData.SaveDataBook(bookJson, BookDataBase.GetBookBase());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Login_textBox.Text == string.Empty || Password_textBox.Text == string.Empty)
            {
                MessageBox.Show("Введите Логин или Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           this.User  = UserDataBase.GetUserBase().FirstOrDefault(u => u.login == Login_textBox.Text && u.password == Password_textBox.Text);

            if (this.User == null)
            {
                MessageBox.Show("Неверный Логин или Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.User is Admin admin)
            {
                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
            }
            else if (this.User is Worker worker)
            {
                WorkerForm workerForm = new WorkerForm(this);
                workerForm.Show();
            }
            else if (this.User is Visitor visitor)
            {
                VisitorForm visitorForm = new VisitorForm(this);
                visitorForm.Show();
            }
            else
            {
                MessageBox.Show("Неизвестный тип пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var loadedUsers = JsonSaveLoadData.LoadDataUser(userJson);
            //if (loadedUsers != null && loadedUsers.Any())
            //{
            //    UserDataBase.UserBase = loadedUsers;
            //}


            //var loadedBooks = JsonSaveLoadData.LoadDataBook(bookJson);
            //if (loadedBooks != null && loadedBooks.Any())
            //{
            //    BookDataBase.books = loadedBooks;

            //}

        }
    }
}
