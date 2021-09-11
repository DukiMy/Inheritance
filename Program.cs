using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Person mr = new Person("John", "Doe", 35, "johndoe@email.com", "Shabadoobi");
            Person mrs = new Person("Mary", "Doe", 32, "marydoe@email.com", "Dabashoobi");
            Student jr = new Student("Junior", "Doe", 7, "juniordoe@email.com", "Bashadoobi", 'a');
            Teacher sr = new Teacher("Senior", "Doe", 64, "seniordoe@email.com", "Badashoobi", true);

            Console.WriteLine(mr.GetInfo());
            Console.WriteLine(mrs.GetInfo());
            Console.WriteLine(jr.GetInfo());
            Console.WriteLine(sr.GetInfo());
        }
    }
}
