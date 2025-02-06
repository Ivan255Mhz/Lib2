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
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lib.Forms
{
    public partial class AdditionForm : Form
    {
        public AdminForm _adminform;
        bool _addEdit;
        public AdditionForm()
        {
            InitializeComponent();
        }

        public AdditionForm(AdminForm adminForm, bool AddEdit)
        {
            InitializeComponent();
            this._adminform = adminForm;
            this._addEdit = AddEdit;
            this.FormClosed += (s, args) => _adminform.Show();
            if (AddEdit)
            {
                this.Text = "Добавить пользователя";
            }
            else
            {
                this.Text = "Изменить сотрудника";
                button1.Text = "Изменить";
                AddNameBox.Text = adminForm.SelectedUser.name;
                AddLoginBox.Text = adminForm.SelectedUser.login;
                AddPasswordBox.Text = adminForm.SelectedUser.password;

            }
        }



        private void AdditionForm_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            AddNameBox.Text = string.Empty;
            AddLoginBox.Text = string.Empty;
            AddPasswordBox.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = AddNameBox.Text;
            string password = AddPasswordBox.Text;
            string login = AddLoginBox.Text;

            if (name == string.Empty || password == string.Empty || login == string.Empty)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //                                       ТУТ ПОШЛИ КОСТЫЛИ  НО РАБОТАЕТ :)
            switch (TypeComboBox.SelectedIndex)
            {

                case 0:
                    if (_addEdit)
                    {
                        UserDataBase.AddUser(new Admin(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    else
                    {
                        UserDataBase.DeleteUser(_adminform.SelectedUser);
                        UserDataBase.AddUser(new Admin(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    break;
                case 1:
                    if (_addEdit)
                    {
                        UserDataBase.AddUser(new Worker(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    else
                    {
                        UserDataBase.DeleteUser(_adminform.SelectedUser);
                        UserDataBase.AddUser(new Worker(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    break;
                case 2:
                    if (_addEdit)
                    {
                        UserDataBase.AddUser(new User(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    else
                    {
                        UserDataBase.DeleteUser(_adminform.SelectedUser);
                        UserDataBase.AddUser(new User(name, login, password));
                        _adminform.UpdateListBox();
                        this.Close();
                    }
                    break;
                default:

                    MessageBox.Show("Вы не выбрали тип пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
            }

        }

        private void AdditionForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
