using MovieReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;

namespace MovieReview.Controllers
{
    public class MovieDetailsController : ApiController
    {
        //// GET: api/MovieDetails
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
       [Route("api/Movies")]
       [HttpGet]
       public List<MovieDetails> GetMovieDetails()
        {
            List<MovieDetails> MovieLists = new List<MovieDetails>();
            MovieDetails MovieList = new MovieDetails();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=MovieReview; integrated security=SSPI");
                con.Open();
                SqlCommand com = new SqlCommand("select * from Movies;", con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    MovieList = new MovieDetails();  
                    MovieList.MovieName = (string)dr["MoviewName"];
                    MovieList.MovieId = (int)dr["MoviewId"];
                    MovieLists.Add(MovieList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something error", ex);
            }
            return MovieLists;
        }


        // GET: api/MovieDetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MovieDetails
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MovieDetails/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MovieDetails/5
        public void Delete(int id)
        {
        }
    }
}
