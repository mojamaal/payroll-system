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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertEmployee IE = new InsertEmployee();
            IE.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            UpdateEmployee UE = new UpdateEmployee();
            UE.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            DeleteEmployee de = new DeleteEmployee();
            de.Show();
            this.Hide();



        }
    }
}
