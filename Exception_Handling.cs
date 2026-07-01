using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    //public class CheckAge
    //{
    //    public void meth(int age)
    //    {
    //        if (age < 18)
    //        {
    //            throw new Exception("Not eligible to vote");
    //        }
    //        Console.WriteLine("Eligible to Vote");
    //    }
    //    public void meth2()
    //    {
    //        try
    //        {
    //            meth(12);
    //        }
    //        catch(Exception e)
    //        {
    //            Console.WriteLine("Caught: " + e.Message);  
    //        }

    //        Console.WriteLine("Program continues...");
    //    }
    //}

    class Custom
    {

        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Custom: Not eligible to vote");
            }
            Console.WriteLine("Eligible to vote");
        }

        public static void meth()
        {
            try
            {
                CheckAge(16);
            }
            catch (AgeException e)
            {
                Console.WriteLine("Caught: " + e.Message);
            }

            Console.WriteLine("Program continues...");
        }
    }
    class AgeException : Exception
    {
        public AgeException(String msg) : base(msg) { }
    }
}
                