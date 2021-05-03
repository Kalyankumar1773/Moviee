using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReview.Models
{
    public class UserReview
    {
        public string MovieName { get; set; }
        public string MovieReview { get; set; }
        public string MovieRating { get; set; }
        public string Username { get; set; }
    }
}