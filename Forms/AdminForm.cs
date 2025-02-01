using Lib.Class;
using Lib.Data;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminForm : Form
    {

        public Form1 _form1;
       
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(Form1 form1)
        {
            InitializeComponent();
            AdminlistBox.DataSource = UserDataBase.GetUserBase();
            this._form1 = form1;
            this.FormClosed += (s,args)=>_form1.Show();
            Exitbutton.Click += (s, args) =>
            {
                _form1.Show();
                this.Close();
            };
        }

         private void UpdateListBox()
        {
            AdminlistBox.DataSource = null; 
            AdminlistBox.DataSource = UserDataBase.GetUserBase(); 
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
