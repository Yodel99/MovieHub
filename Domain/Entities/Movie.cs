using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Movie
    {
        public ObjectId Id { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public int Duritation { get; set; }
        public float Rating { get; set; }
        //public IList<Genres> Genres { get; set; }
        //public IList<Actor> Stars { get; set; }

        public Movie(string movieName, string movieDescription, int duritation, float rating)

        {
            MovieName = movieName;
            MovieDescription = movieDescription;
            Duritation = duritation;
            Rating = rating;
            // Genres = genres;
            // Stars = stars;

        }
    }
}
