using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoPayrollSystem
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Employee emp = new Employee();
            emp.updateEmployee(textBox1.Text,comboBox1.Text,textBox2.Text);

            MessageBox.Show("Successfully updated!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeMenu emp = new EmployeeMenu();
            emp.Show();
            this.Hide();
        }
    }
}
