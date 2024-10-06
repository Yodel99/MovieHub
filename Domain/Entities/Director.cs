using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Director
    {
        private int DirectorID { get; set; }
        private string DirectorFirstName { get; set; }
        private string DirectorLastName { get; set; }

        public Director(string directorFirstName, string directorLastName)
        {
            DirectorFirstName = directorFirstName;
            DirectorLastName = directorLastName;
        }
    }
}
