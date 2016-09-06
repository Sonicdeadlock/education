using System;

namespace Education
{
    public class User
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} is {2} years old", this.FirstName, this.LastName, this.age);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(User))
                return false;
            User u = (User) obj;
            return (this.Age.Equals(u.age) && this.FirstName.Equals(u.FirstName) && this.LastName.Equals(u.LastName));
        }
    }
}