using Lib.Class;
using Lib.Data;
using Lib.Forms;

namespace Lib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Login_textBox.Text == string.Empty || Password_textBox.Text == string.Empty)
            {
                MessageBox.Show("Введите Логин или Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = UserDataBase.GetUserBase().FirstOrDefault(u => u.login == Login_textBox.Text && u.password == Password_textBox.Text);

            if (user == null)
            {
                MessageBox.Show("Неверный Логин или Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user is Admin admin)
            {
                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
            }
            if(user is Worker worker)
            {
                WorkerForm workerForm = new WorkerForm(this);
                workerForm.Show();
            }
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
