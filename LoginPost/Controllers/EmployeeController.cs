using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoginPost.Models;

namespace LoginPost.Controllers
{
    public class EmployeeController : ApiController
    {
        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=EmployeeManagement;Trusted_Connection=True;";
        [HttpPost]
        public Employe EmployeLogin(Employe employe)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("EmployeLogin", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Username", employe.Username);
            command.Parameters.AddWithValue("Password", employe.Password);


            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
           
            employe.Id = Convert.ToInt32(reader["Id"]);
            employe.Name = reader["Name"].ToString();
            employe.Age = Convert.ToInt32(reader["Age"]);
            employe.Salary = Convert.ToInt32(reader["Salary"]);



            reader.Close();
            con.Close();
            return employe;





        }
    }
}
