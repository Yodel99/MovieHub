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
    public class Actor
    {
        public ObjectId Id { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        

        public Actor(string actorFirstName, string actorLastName) 
        { 
            ActorFirstName = actorFirstName;
            ActorLastName = actorLastName;
        }
    }
}
