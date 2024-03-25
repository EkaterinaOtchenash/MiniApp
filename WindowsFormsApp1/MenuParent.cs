using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FolderForModel;

namespace WindowsFormsApp1
{
    public partial class MenuParent : Form
    {
        public MenuParent()
        {
            InitializeComponent();
        }

        private void MenuParent_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();

            labelName.Text = AuthorizationForm.Enter_User.First_Name + " " + AuthorizationForm.Enter_User.Second_Name;
            labelRole.Text = AuthorizationForm.Enter_User.Role;

            switch (AuthorizationForm.Enter_User.Role)
            {
                case "Администратор":
                    button1.Text = "Показать арендаторов";
                    break;

                case "Менеджер А":
                    button1.Text = "Показать ТЦ";
                    break;
                case "Менеджер С":
                    button1.Text = "Показать ТЦ";
                    break;
                
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (AuthorizationForm.Enter_User.Role)
            {
                case "Администратор":
                    TenantsForm frm2 = new TenantsForm();
                    frm2.Show();
                    this.Hide();
                    break;

                case "Менеджер А":
                    MallForm frm1 = new MallForm();
                    frm1.Show();
                    this.Hide();
                    break;
                case "Менеджер С":
                    MallForm frm3 = new MallForm();
                    frm3.Show();
                    this.Hide();
                    break;

            }
        }
    }
}
