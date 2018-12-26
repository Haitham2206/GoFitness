using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Course
    {
        public int Price, QuantityOfMembers, MaxCapacity;
       public bool IsAvailable;
       public string NameOfCourse, CodeOfCourse;
       public DateTime JoinDate, ExpirationDate;
        public Course(int price, string codeOfCourse, int quantityOfMembers, bool isAvailable, string nameOfCourse, DateTime joinDate, DateTime expirationDate,int maxCapacity)
        {
            this.Price = price;
            this.CodeOfCourse = codeOfCourse;
            this.QuantityOfMembers = quantityOfMembers;
            this.IsAvailable = isAvailable;
            this.NameOfCourse = nameOfCourse;
            this.JoinDate = joinDate;
            this.ExpirationDate = expirationDate;
        }
        //proprty
        public int Price_prop{get{return Price;}set{ Price=value;}}
        public string CodeOfCourse_prop { get { return CodeOfCourse; } set { CodeOfCourse = value; } }
        public int MaxCapacity_prop { get { return MaxCapacity; } set { MaxCapacity = value; } }
        public int QuantityOfMembers_prop { get { return QuantityOfMembers; } }
        public DateTime JoinDate_prop { get { return JoinDate; } set { JoinDate = value; } }
        public DateTime ExpirationDate_prop { get { return ExpirationDate; } set { ExpirationDate = value; } }
        //function
        public bool Course_IsAvailable(int CodeOfCourse, int MaxCapacity) //
        {
            return true;
 
        }
        



    }
}
