using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace GrifindoPayrollSystem
{
    public class Employee
    {

        public void InsertEmployee(string name,string address,string dob,string gender,string telephone,string monthly_sal,string allowances,string overtime_rate,string leave) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Employee(Name,Address,DOB,Gender,Telephone,Monthly_Sal,Allowances,Overtime_Rate,Leaves) values ('"+name+"','"+address+"','"+dob+"','"+gender+"','"+telephone+"','"+monthly_sal+"','"+allowances+"','"+overtime_rate+"','"+leave+"')";

            cmd.ExecuteReader();


            con.Close();








        }

        public SqlDataAdapter getAllEmployees() {

            SqlDataAdapter sda = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            sda = new SqlDataAdapter("select * from Employee", con);



            con.Close();


            return sda;
        }


        public SqlDataAdapter searchEmployees(string name)
        {

            SqlDataAdapter sda = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            sda = new SqlDataAdapter("select * from Employee where Name like '%"+name+"%'", con);



            con.Close();


            return sda;
        }


        public void updateEmployee(string id,string field,string val) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Employee set "+field+"='"+val+"' where Id='"+id+"'";

            cmd.ExecuteReader();


            con.Close();





        }



        public void deleteEmployee(string id) {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from Employee where Id='"+id+"'";

            cmd.ExecuteReader();


            con.Close();





        }





    }
}
