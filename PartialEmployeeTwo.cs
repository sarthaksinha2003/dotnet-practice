using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public partial class PartialEmployee
    {
        public PartialEmployee(string FirstName,string LastName, double salary, string gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = salary;
            this.Gender = gender;
        }
        public void DisplayFullName()
        {
            Console.WriteLine("Full Name is :" + FirstName + " " + LastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("First Name :" + FirstName);
            Console.WriteLine("Last Name :" + LastName);
            Console.WriteLine("Gender :" + Gender);
            Console.WriteLine("Salary :" + Salary);
        }
    }
}
