namespace Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual string GetInfo()
        {
            return $"Firstname: {FirstName} LastName: {LastName} Age: {Age} Email: {Email} Password: {Password}";
        }

        public Person(string firstName, string lastName, int age, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Password = password;
        }

        public Person()
        {

        }
    }
}