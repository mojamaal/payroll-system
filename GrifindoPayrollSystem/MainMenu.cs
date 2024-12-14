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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            Settings.SetUpValues();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu em = new EmployeeMenu();
            em.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu();
            sm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu sm = new SalaryMenu();
            sm.Show();
            this.Hide();
        }
    }
}
