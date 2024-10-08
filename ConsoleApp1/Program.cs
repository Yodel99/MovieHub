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
            // Ladda anslutningssträngen från appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("MovieHub");

            // Skapa en instans av MovieHubContext
            var db = new MovieHubContext(connectionString);

            // Skapa en film och lägg till den i databasen
            Movie movie = new Movie("Joel spelar fotboll", "Hahahaha", 200, 8);
        
            // Lägg till filmen i MongoDB
            db.Movies.InsertOne(movie);

            Console.WriteLine("Filmen har lagts till i databasen.");

        }
    }
}