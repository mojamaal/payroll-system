using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace GrifindoPayrollSystem
{
    public class Settings
    {

        public void AddValues(string sal_begin_date,string sal_end_date,string date_range,string tax,string leaves) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            
            //update salary begin date

            cmd.CommandText = "update Settings set Value='"+sal_begin_date+ "' where Name='salary_begin_date'";

            cmd.ExecuteReader();

            con.Close();



            //update salary end date
            con.Open();

            cmd.CommandText = "update Settings set Value='" + sal_end_date + "' where Name='salary_end_date'";

            cmd.ExecuteReader();

            con.Close();



            //update date range
            con.Open();

            cmd.CommandText = "update Settings set Value='" + date_range + "' where Name='date_range'";

            cmd.ExecuteReader();

            con.Close();


            //update Tax
            con.Open();

            cmd.CommandText = "update Settings set Value='" + tax + "' where Name='Tax'";

            cmd.ExecuteReader();

            con.Close();


            //update Leaves
            con.Open();

            cmd.CommandText = "update Settings set Value='" + leaves + "' where Name='Leaves'";

            cmd.ExecuteReader();

            con.Close();

        }

        public static void SetUpValues() {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Settings";

            SqlDataReader sdr = cmd.ExecuteReader();

            string[]vals=new string[5];

            int k = 0;
            while(sdr.Read()){

                vals[k] = sdr["Value"].ToString();
                k = k + 1;
            
            
            }

            SettingsVal.sal_begin_date = vals[0];
            SettingsVal.sal_end_date = vals[1];
            SettingsVal.date_range = vals[2];
            SettingsVal.tax = vals[3];
            SettingsVal.leaves = vals[4];


            con.Close();
        
        
        }

    }
}
