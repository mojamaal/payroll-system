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
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Settings s = new Settings();


            string date1 = dateTimePicker1.Text;

            string date2 = dateTimePicker2.Text;

            string salary_cycle_start_date = date1.Split('/')[1];

            string salary_cycle_end_date = date2.Split('/')[1];



            int month1 = Convert.ToInt32(date1.Split('/')[0]);

            int month2= Convert.ToInt32(date2.Split('/')[0]);


            if (((month1 + 1) == month2) && (Convert.ToString((dateTimePicker2.Value - dateTimePicker1.Value).Days) == textBox1.Text))
            {

                s.AddValues(salary_cycle_start_date,salary_cycle_end_date,textBox1.Text,textBox3.Text,textBox2.Text);

                MessageBox.Show("Successfully Entered All the values!");

            }
            else {


                MessageBox.Show("Value Error! Please Re-Try!");

            }








        }
    }
}
