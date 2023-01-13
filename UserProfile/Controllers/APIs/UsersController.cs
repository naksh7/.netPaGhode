using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserProfile.Models;

namespace UserProfile.Controllers.APIs
{
    public class UsersController : ApiController
    {
        string strcon = ConfigurationManager.ConnectionStrings["MedicineConnection"].ConnectionString;
        [HttpGet]
        public string Get(string userName, string password)
        {
            DataTable userDt = new DataTable();
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "select firstName, lastName, contact, dob, email,password,userName from Users where userName like '" + userName + "' and Password like '" + password + "'";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(userDt);
                }
            }
            return JsonConvert.SerializeObject(userDt);
        }
    }
}
