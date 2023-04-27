using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFOne.Codes
{
    public class User
    {
        public User()
        {
        }

        public User(int id, string lastName, string firstName, int age, string city)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            City = city;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }




    }
}
