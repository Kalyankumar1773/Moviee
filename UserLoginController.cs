using MovieReview.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieReview.Controllers
{
    public class UserLoginController : ApiController
    {
        // GET: api/UserLogin
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        [Route("apli/loginuser")]
        [HttpGet]
        public List<UserLogin> GetLoginData()
        {
            List<UserLogin> logindatas = new List<UserLogin>();
            UserLogin logindata = new UserLogin();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=MovieReview; integrated security=SSPI");
                con.Open();
                SqlCommand com = new SqlCommand("select * from UserRegistrationDetails;", con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    logindata = new UserLogin();
                    //logindata.UserId = (int)dr["UserId"];
                    logindata.username = (string)dr["UserName"];
                    logindata.password = (string)dr["Password"];
                    logindatas.Add(logindata);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something error", ex);
            }
            return logindatas;
        }
    }

        // GET: api/UserLogin/5
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST: api/UserLogin
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT: api/UserLogin/5
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE: api/UserLogin/5
    //    public void Delete(int id)
    //    {
    //    }
  //  }
}
