using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Operator_Overloading
    {
        public void meth()
        {
            Money m1 = new Money(100);
            Money m2 = new Money(200);
            Money m3 = m1 + m2;
            Console.WriteLine("Addition: " + m3.amount);

            Money m4 = m2 - m1;
            Console.WriteLine("Subtraction: " + m4.amount);
        }
    }
    public class Money
    {
        public int amount;
        public Money(int amount)
        {
            this.amount = amount;
        }
        public static Money operator +(Money a, Money b)
        {
            return new Money(a.amount + b.amount);
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a.amount - b.amount);
        }
    }
}
