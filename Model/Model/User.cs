using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<User> UserList { get; set; }

        public User()
        {
            List<User> ul = new List<User>();
            ul.Add(new User(ID = 1, FirstName = "John", LastName = "Brown"));
            ul.Add(new User(ID = 2, FirstName = "Jane", LastName = "Brown"));
            ul.Add(new User(ID = 3, FirstName = "Franz", LastName = "Crosbourne"));
            ul.Add(new User(ID = 4, FirstName = "Berry", LastName = "Crosbourne"));
            ul.Add(new User(ID = 5, FirstName = "Clive", LastName = "Francis"));
            ul.Add(new User(ID = 6, FirstName = "Yacira", LastName = "Francis"));
            ul.Add(new User(ID = 7, FirstName = "Natalia", LastName = "Francis"));
            ul.Add(new User(ID = 8, FirstName = "Jack", LastName = "Reacher"));
            this.UserList = ul;
        }

        public User(int id, string firstName, string lastName)
        {
            // TODO: Complete member initialization
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }        
    }
}
