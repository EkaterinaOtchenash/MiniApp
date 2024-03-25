using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FolderForModel;

namespace WindowsFormsApp1
{
    public partial class MallForm : Form
    {

        public static Model1 db = new Model1();
        public MallForm()
        {
            InitializeComponent();
        }

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AuthorizationForm fm = new AuthorizationForm();
            fm.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (db.Mall.ToList().Count == 0)
            {
                MessageBox.Show("Данные отсутствуют");
                return;
            }

            Mall currentmoto = db.Mall.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show($@"ВЫ действительно хотите удалить объект с ID - {currentmoto.ID}", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.Mall.Remove(currentmoto);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mallBindingSource.DataSource = db.Mall.ToList();

                }
            }
        }

        private void MallForm_Load(object sender, EventArgs e)
        {
            mallBindingSource.DataSource = db.Mall.ToList();

            if (db.Mall.ToList().Count == 0) { return; }
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (db.Mall.ToList().Count == 0) { return; }
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Visible = false;
            form.Show();
        }
    }
}
