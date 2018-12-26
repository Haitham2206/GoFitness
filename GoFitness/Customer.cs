using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Customer:Person
    {
        public double Weight;
        public string Course1;
        public string Course2;
        public string Course3;
        public Customer(string firstName, string lastName, string id, int age, string phoneNumber,
                        string email, string userName, string password, double weight, string course1,
                        string course2, string course3)
            :base( firstName,  lastName,  id,  age,  phoneNumber,  email,  userName, password)
        {
            this.Weight = weight;
            this.Course1 = course1;
            this.Course2 = course2;
            this.Course3 = course3;
        }
        //property
        public double Weight_prop { get { return Weight; } set { Weight = value; } }
        public string CourseI_prop { get { return Course1; } set { Course1 = value; } }
        public string CourseII_prop { get { return Course2; } set { Course2 = value; } }
        public string CourseIII_prop { get { return Course3; } set { Course3 = value; } }
        //function
        public void RegisterToCourse()
        {

        }

    }
}
