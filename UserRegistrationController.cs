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
    public class UserRegistrationController : ApiController
    {
        // GET: api/UserRegistration
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserRegistration/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserRegistration
        public void Post([FromBody]string value)
        {
        }
        [Route("api/UserRegistrationDetails")]
        [HttpPost]

        public UserRegistration PostUser(UserRegistration obj)
        {
            //List<UserRegistration> UserData = new List<UserRegistration>();
            UserRegistration User = new UserRegistration();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=MovieReview; integrated security=SSPI");

                con.Open();
                string s = "INSERT INTO UserRegistrationDetails Values('" + obj.UserName + "','" + obj.Password + "','" + obj.ConfirmPassword + "','" + obj.Email + "')";
                SqlCommand Scommand = new SqlCommand(s, con);
                //User.UserName = "";
                //User.Password = "";
                //User.ConfirmPassword = "";
                //User.Email = "";
                //UserData.Add(User);
                Scommand.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            return User;

        }

        // PUT: api/UserRegistration/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserRegistration/5
        public void Delete(int id)
        {
        }
    }
}
