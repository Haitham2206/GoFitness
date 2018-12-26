using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Id;
        public string PhoneNumber;
        public string Email;
        public string UserName;
        public string Password;
        public int Age; 
              
        protected Person(string firstName, string lastName, string id, int age, string phoneNumber, string email, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
        }
        protected string FirstName_prop { get { return FirstName; } set { FirstName = value; } }
        protected string LastName_prop { get { return LastName; } set { LastName = value; } }
        protected string Id_prop { get { return Id; } set { Id = value; } }
        protected int age_prop { get { return Age; } set { Age = value; } }
        protected string PhoneNumber_prop { get { return PhoneNumber; } set { PhoneNumber = value; } }
        protected string Email_prop { get { return Email; } set { Email = value; } }
        protected string UserName_prop { get { return UserName; } set { UserName = value; } }
        protected string Password_prop { get { return Password; } set { Password = value; } }

    }
}
