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
    public class UserReviewController : ApiController
    {
        // GET: api/UserReview
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("api/UserReview")]
        [HttpPost]
        public List<UserReview> PostUserReview(UserReview obj)
        {
            
            List<UserReview> UserReviews = new List<UserReview>();
            UserReview User = new UserReview();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=MovieReview; integrated security=SSPI");

                con.Open();
                string s = "INSERT INTO UserReview Values('" + obj.MovieName + "','" + obj.MovieReview + "','" + obj.MovieRating + "','" + obj.Username + "')";
                SqlCommand Scommand = new SqlCommand(s, con);
                Scommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            return UserReviews;
        }


        // GET: api/UserReview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserReview
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserReview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserReview/5
        public void Delete(int id)
        {
        }
    }
}
