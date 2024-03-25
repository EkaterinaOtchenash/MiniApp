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
    public partial class AuthorizationForm : Form
    {
        public static Workers Enter_User;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            Enter_User = model1.Workers.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.Role)
                {
                    case "Администратор":
                        FormAdmin formAdm = new FormAdmin();
                        formAdm.Show();
                        this.Hide();
                        break;

                    case "Менеджер А":
                        FormManA formManager = new FormManA();
                        formManager.Show();
                        this.Hide();
                        break;
                    case "Менеджер С":
                        ManBForm formManagerB = new ManBForm();
                        formManagerB.Show();
                        this.Hide();
                        break;
                    default:
                        throw new Exception("Роль удалена");
                      
                }

            }
        }
    }
}
