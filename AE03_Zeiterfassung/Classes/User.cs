using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE03_Zeiterfassung.Classes
{
    internal class User
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public  bool IsPresent { get; set; } = false;

        //public string FirstName => this.firstName;
        //public string LastName => this.lastName;

        public User(int id, string firstName, string lastName, bool isPresent)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsPresent = isPresent;
        }

        public User(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
