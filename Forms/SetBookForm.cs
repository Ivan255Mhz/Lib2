using Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
            BooktextBox.BackColor = _workerForm.SelectedUser.BackColor;
            BooktextBox.ForeColor = _workerForm.SelectedUser.TextColor;
            BooktextBox.Font = _workerForm.SelectedUser.Font;


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
            BooktextBox.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooktextBox.BackColor = Color.White;
            BooktextBox.ForeColor = Color.Black;
            BooktextBox.Font= new Font("Segoe UI", 9);
        }

        private void segoeUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float size = _workerForm.SelectedUser.Font.Size;
            _workerForm.SelectedUser.Font = new Font("Segoe UI", size);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void tahomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float size = _workerForm.SelectedUser.Font.Size;
            _workerForm.SelectedUser.Font = new Font("Tahoma", size);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void simSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float size = _workerForm.SelectedUser.Font.Size;
            _workerForm.SelectedUser.Font = new Font("SimSum", size);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float size = _workerForm.SelectedUser.Font.Size;
            _workerForm.SelectedUser.Font = new Font("Times New Roman", size);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string fontName = _workerForm.SelectedUser.Font.FontFamily.Name;
            _workerForm.SelectedUser.Font = new Font(fontName, 9);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string fontName = _workerForm.SelectedUser.Font.FontFamily.Name;
            _workerForm.SelectedUser.Font = new Font(fontName, 10);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string fontName = _workerForm.SelectedUser.Font.FontFamily.Name;
            _workerForm.SelectedUser.Font = new Font(fontName, 11);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string fontName = _workerForm.SelectedUser.Font.FontFamily.Name;
            _workerForm.SelectedUser.Font = new Font(fontName, 12);
            BooktextBox.Font = _workerForm.SelectedUser.Font;
        }
    }
}
