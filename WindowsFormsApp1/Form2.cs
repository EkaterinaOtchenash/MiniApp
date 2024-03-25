using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.FolderForModel;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private List<Mall> MotorbikeList = MallForm.db.Mall.ToList();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MallForm fm = new MallForm();
            fm.Visible = true;
            this.Close();
        }

    

        private int FLplus1()
        {
            int max = 0;
            foreach (Mall TB in MotorbikeList)
                if (max < TB.ID) { max = TB.ID; }
            return ++max;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(townTextBox.Text))
            {
                MessageBox.Show("Поля Name и Status не должны быть пустыми");
                return;
            }
            try
            {
                Convert.ToInt32(amount_PTextBox.Text);
                Convert.ToInt32(coeff_costTextBox.Text);
                Convert.ToInt32(costTextBox.Text);
                Convert.ToInt32(floorTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Поля Amount_P, Coeff_cost, Cost, Floor могут содержать только целочисленные значения");
                return;
            }

           


            Mall nmot = new Mall();

            nmot.ID = FLplus1();
            nmot.Amount_P = Convert.ToInt32(amount_PTextBox.Text);
            nmot.Coeff_cost = Convert.ToInt32(coeff_costTextBox.Text);
            nmot.Cost = Convert.ToInt32(costTextBox.Text);
            nmot.Floor = Convert.ToInt32(floorTextBox.Text);
            nmot.Name = nameTextBox.Text;
            nmot.Town = townTextBox.Text;
            nmot.Status = statusComboBox.Text;
            

            try
            {
                MallForm.db.Mall.Add(nmot);
               MallForm.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Данные успешно добавлены");
            MallForm form = new MallForm();
            form.Visible = true;
            this.Close();

        }


        private void ReturnExit_Click(object sender, EventArgs e)
        {
            MallForm fm = new MallForm();
            fm.Visible = true;
            this.Close();
        }
    }
}

