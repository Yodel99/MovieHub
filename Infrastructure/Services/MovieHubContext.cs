using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Infrastructure.Services;

public class MovieHubContext
{
  
    private readonly IMongoDatabase _database;

    public MovieHubContext(string connectionString)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("Movies");
    }

    public IMongoCollection<Movie> Movies => _database.GetCollection<Movie>("movies");

}

