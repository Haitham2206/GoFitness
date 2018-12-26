using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFitness
{
    public class Manager:Employee_class
    {
        public double Balance;
        public Manager(string firstName, string lastName, string id, int age, string phoneNumber, string email, string userName, string password,double balance)
            :base(firstName,lastName,id,age,phoneNumber,email,userName,password)
        {
            this.Balance=balance;
        }

        
        //proprty
        public double MoneyInTheBank { get { return Balance; } } 
        //Methods
        public void FireEmployee(Employee_class employee)
        {
           
        }
        public void AddEmployee(Employee_class employee)
        {

        }
      
        



    }
}
