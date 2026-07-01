using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    //public class Employees
    //{
    //    public string Name;
    //    public int Gender;
    //    public Employees(String name,int gender)
    //    {
    //        this.Name = name;
    //        this.Gender = gender;
    //    }
    //    public static String getGender(int gen)
    //    {
    //        switch (gen)
    //        {
    //            case 0:  return "Unknown";
    //            case 1:  return "Male";
    //            case 2:  return "Female";
    //            default: return "Invalid Data for Gender";
    //        }
    //    }
    //}
    //public class needOFEnum
    //{
    //    public void meth()
    //    {
    //        List<Employees> empList = new List<Employees>();
    //        empList.Add(new Employees("Sarthak", 1));
    //        empList.Add(new Employees("Sinha", 1));
    //        empList.Add(new Employees("Mr. White", 1));
    //        empList.Add(new Employees("Mis. Pink", 2));
    //        foreach (Employees emp in empList)
    //        {
    //            Console.WriteLine("Name = " + emp.Name + " & Gender = " + Employees.getGender(emp.Gender));
    //        }
    //    }
    //}

    enum PaymentMethod
    {
        CreditCard = 1,
        UPI = 2,
        NetBanking = 3,
        Cash = 4
    }
    public class payment
    {
        public void meth()
        {
            int paymentId = 2;//let suppose this comes from the database or fortend 
            PaymentMethod paymentMethod = (PaymentMethod)paymentId;
            Console.WriteLine("Selected Payment: " + paymentMethod);

            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    Console.WriteLine("Opening Card Payment Gateway...");
                    break;
                case PaymentMethod.UPI:
                    Console.WriteLine("Opening UPI Gateway...");
                    break;
                case PaymentMethod.NetBanking:
                    Console.WriteLine("Opening Net Banking Gateway...");
                    break;
                case PaymentMethod.Cash:
                    Console.WriteLine("Cash Payment Selected.");
                    break;
                default:
                    Console.WriteLine("Invalid Payment Method");
                    break;
            }
        }
    }
}