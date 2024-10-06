using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Actor
    {
        private int ActorID { get; set; }
        private string ActorFirstName { get; set; }
        private string ActorLastName { get; set; }
        

        public Actor(string actorFirstName, string actorLastName) 
        { 
            ActorFirstName = actorFirstName;
            ActorLastName = actorLastName;
        }
    }
}
