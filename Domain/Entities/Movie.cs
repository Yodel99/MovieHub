using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie
    {
        private int MovieID { get; set; }
        private string MovieName { get; set; }
        private string MovieDescription { get; set; }
        private int Duritation { get; set; }
        private float Rating { get; set; }
        private IList<Genres> Genres { get; set; }
        private IList<Actor> Stars { get; set; }

        public Movie(string movieName, string movieDescription, int duritation, float rating, IList<Genres> genres, IList<Actor> stars)
        {
            MovieName = movieName;
            MovieDescription = movieDescription;
            Duritation = duritation;
            Rating = rating;
            Genres = genres;
            Stars = stars;
        }
    }
}
