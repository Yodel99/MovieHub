using System;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // TEst test
            //Använd anslutningssträngen för att skapa MovieHubContext
            var db = MovieHubContext.Create();
         
         Movie movie = new Movie("Offside", "Gäng grabbar som spelar boll", 200, 8);
         
         db.Add(movie);
         
         db.SaveChanges();
         

        }
    }
}