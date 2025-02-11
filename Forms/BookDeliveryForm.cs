using Lib.Class;
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
    public partial class BookDeliveryForm : Form
    {
        public WorkerForm _workerForm;
        public BookDeliveryForm(WorkerForm workerForm)
        {
            InitializeComponent();
            _workerForm = workerForm;
            VisitorlistBox.DataSource = workerForm.VisitorsOnly();
            VisitorlistBox.DisplayMember = nameof(Visitor.name);
            this.FormClosed += (s, args) => _workerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor visitor = VisitorlistBox.SelectedItem as Visitor;

            int index = UserDataBase.UserBase.FindIndex(u => u.login == visitor.login);

            if (UserDataBase.UserBase[index] is Visitor vis)
            {
                vis.AddBook(_workerForm.SelectedUser);
            }
            BookDataBase.DeleteBook(_workerForm.SelectedUser);
            _workerForm.UpdateListBox();
            this.Close();


        }
    }
}
