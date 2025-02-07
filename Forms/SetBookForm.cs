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
using static System.Windows.Forms.DataFormats;

namespace Lib.Forms
{
    public partial class SetBookForm : Form
    {
        private WorkerForm _workerForm;
        public SetBookForm(WorkerForm workerForm)
        {
            InitializeComponent();

            _workerForm = workerForm;

            BookGroupBox.Text = _workerForm.SelectedUser.name;
            BooktextBox.Text = _workerForm.SelectedUser.text;

            this.FormClosed += (s, args) => _workerForm.Show();
        }

        private void SetBookForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _workerForm.SelectedUser.text = BooktextBox.Text;
            _workerForm.SelectedUser.BackColor = BooktextBox.BackColor;
            _workerForm.SelectedUser.TextColor = BooktextBox.ForeColor;
            this.Close();
        }

        private void очиститьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooktextBox.Text = string.Empty;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TextFile = "";
            OpenFileDialog open = new OpenFileDialog();
            // создали экземпляр установим фильтр для файлов
            open.Filter = "All txt files (*.txt)|*.txt";
            open.FilterIndex = 1;// по умолчанию фильтруются
                                 // текстовые файлы
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                TextFile = reader.ReadToEnd(); // считываем файл до конца
                reader.Close(); // закрываем reader
            }
            BooktextBox.Text = TextFile;
        }

        private void стильToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooktextBox.BackColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooktextBox.BackColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooktextBox.BackColor = Color.Green;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BooktextBox.ForeColor = Color.Red;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BooktextBox.ForeColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BooktextBox.ForeColor= Color.Green;
        }
    }
}
