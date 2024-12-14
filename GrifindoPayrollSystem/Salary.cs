using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace GrifindoPayrollSystem
{
    public class Salary
    {

        public void InsertSalaries(string empid,int month,double nopay,double basepay,double grosspay) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Salary(EmpId,Month,NoPay,BasePay,GrossPay) values ('"+empid+"','"+month+"','"+nopay+"','"+basepay+"','"+grosspay+"')";

            cmd.ExecuteReader();

            con.Close();
        
        
        }
















    }
}
