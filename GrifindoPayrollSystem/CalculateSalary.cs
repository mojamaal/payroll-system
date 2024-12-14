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
    public partial class CalculateSalary : Form
    {

        private double basic_sal;
        private double allowances;
        private double OTRate;
        private int leaves;



        public CalculateSalary()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();

            string date1 = dateTimePicker1.Text;

            string date2 = dateTimePicker2.Text;

            string salary_cycle_start_date = date1.Split('/')[1];

            string salary_cycle_end_date = date2.Split('/')[1];



            int month1 = Convert.ToInt32(date1.Split('/')[0]);

            int month2 = Convert.ToInt32(date2.Split('/')[0]);


            if (((month1 + 1) == month2) && (leaves>Convert.ToInt32(textBox1.Text))&&(Convert.ToInt32(textBox2.Text)>=((Convert.ToInt32(textBox1.Text))+(Convert.ToInt32(textBox5.Text))))&&(leaves>=Convert.ToInt32(textBox1.Text)))
            {

                leaves = leaves - Convert.ToInt32(textBox1.Text);

                ee.updateEmployee(textBox9.Text,"Leaves",""+leaves);

                int no_pay_days=Convert.ToInt32(textBox2.Text)-((Convert.ToInt32(textBox1.Text))+(Convert.ToInt32(textBox5.Text)));


                double no_pay_value = ((Convert.ToDouble(textBox3.Text)) / ((dateTimePicker2.Value - dateTimePicker1.Value).Days)) * no_pay_days;


                double base_pay = (Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text)) + (Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text));

                double gross_pay = base_pay - (no_pay_value + ((base_pay * Convert.ToDouble(textBox8.Text)) / 100));

                Salary ss = new Salary();

                ss.InsertSalaries(textBox9.Text,month2,no_pay_value,base_pay,gross_pay);


                label11.Text = "No Pay : " + no_pay_value;
                label12.Text = "Base Pay : " + base_pay;
                label13.Text = "Gross Pay : " + gross_pay;



            }
            else
            {


                MessageBox.Show("Value Error! Please Re-Try!");

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Employee where Id='"+textBox9.Text+"'";

            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read()){

                basic_sal = Convert.ToDouble(sdr["Monthly_Sal"].ToString());
                allowances = Convert.ToDouble(sdr["Allowances"].ToString());
                OTRate = Convert.ToDouble(sdr["Overtime_Rate"].ToString());
                leaves = Convert.ToInt32(sdr["Leaves"].ToString());
                
            
            
            
            
            }

            con.Close();

            textBox3.Text = ""+basic_sal;
            textBox4.Text = ""+allowances;
            textBox6.Text = ""+OTRate;
            textBox8.Text = SettingsVal.tax;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu sm = new SalaryMenu();
            sm.Show();
            this.Hide();
        }
    }
}
