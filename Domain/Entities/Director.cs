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
    public class Director
    {
        public ObjectId Id { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }

        public Director(string directorFirstName, string directorLastName)
        {
            DirectorFirstName = directorFirstName;
            DirectorLastName = directorLastName;
        }
    }
}
