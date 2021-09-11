using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Person
    {
        public bool IsAdmin { get; set; } = true;

        public Teacher(string firstName, string lastName, int age, string email, string password, bool isAdmin) : base(firstName, lastName, age, email, password)
        {
            IsAdmin = isAdmin;
        }

        public Teacher()
        {

        }
    }
}
