using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        public char Grade { get; set; }

        public override string GetInfo()
        {
            return $"Firstname: {FirstName} LastName: {LastName} Age: {Age} Email: {Email} Password: {Password} Grade: {Grade}";
        }

        public Student(string firstName, string lastName, int age, string email, string password, char grade) : base(firstName, lastName, age, email, password)
        {
            Grade = grade;
        }

        public Student()
        {

        }
    }
}
