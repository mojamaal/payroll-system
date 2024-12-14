using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace GrifindoPayrollSystem
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();

            SqlDataAdapter sda = emp.getAllEmployees();

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();

            SqlDataAdapter sda = emp.searchEmployees(textBox1.Text);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeMenu emp = new EmployeeMenu();
            emp.Show();
            this.Hide();
        }
    }
}
