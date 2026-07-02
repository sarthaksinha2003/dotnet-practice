using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject{
    internal class Program{
        static void Main(string[] args){

            // Demo

            //Console.WriteLine("Hello World!");
            //Console.ReadKey();// read the pressed key

            // Read String

            //Console.Write("Enter Your Name: ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Hello " + name + "!");

            // Read Numbers

            //Console.WriteLine("Eneter two Numbers:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int res = number1 + number2;
            //Console.WriteLine(res);

            //ASCII

            //Console.WriteLine("Enter a Key");
            //int key1 = Console.Read();
            //int key2 = Console.Read();
            //Console.WriteLine(key1 + " " + key2);

            //Console Class Properties

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Title = "Understanding Console Class";
            //Console.WriteLine("BackgroundColor: Red");
            //Console.WriteLine("ForegroundColor: Black");
            //Console.WriteLine("Title: Understanding Console Class");

            //DataType
            //DataType.dataType();

            //casting
            //TypeCasting.casting();

            //poly
            //Poly p = new Poly("Sarthak",22);
            //Console.WriteLine(p.getDetails());
            //Console.WriteLine(p.getName());
            //Console.WriteLine(p.getAge());

            //destructor

            //Destructor obj1 = new Destructor();
            //Destructor obj2 = new Destructor();
            //obj1 = null;
            //GC.Collect();
            //Console.WriteLine(obj2.num());

            //Encapsulation

            //try
            //{
            //    Encapsulation bank = new Encapsulation();
            //    bank.setBalance(1);
            //    bank.addBalance(100);
            //    Console.WriteLine("Available Balance: " + bank.getBalance());
            //    bank.addBalance(-100);
            //    Console.WriteLine("Available Balance: " + bank.getBalance());
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Abstraction

            //Abstraction abs = new Abstraction();
            //abs.Transaction();

            //Inheritance

            //child inheri = new child();
            //inheri.meth(inheri);

            //ISA and HASA

            //Cuboid obj = new Cuboid(10,20,30);
            //int ans = obj.volume();
            //Console.WriteLine("Volume is: " + ans);
            //HASA obj = new HASA();
            //obj.meth();

            //Operator Overloading

            //Operator_Overloading obj = new Operator_Overloading();
            //obj.meth();

            //Partial Class

            //PartialEmployee emp = new PartialEmployee("Sarthak","Sinha",100000000,"Male");
            //emp.DisplayFullName();
            //emp.DisplayEmployeeDetails();

            //struct 

            //Point p1 = new Point();

            //p1.X = 10;
            //p1.Y = 20;

            //Point p2 = p1;

            //p2.X = 50;

            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);

            //enum

            //needOFEnum check = new needOFEnum();
            //check.meth();

            //payment pay = new payment();
            //pay.meth();

            //Exception Handling

            //CheckAge voterId = new CheckAge();
            //voterId.meth2();

            //Custom.meth();

            //Entension methods

            //OldClass obj = new OldClass();
            //obj.Test3();

            //collections

            ArrayListNonGeneric obj = new ArrayListNonGeneric();
            obj.display();
        }
    }
    //struct Point
    //{
    //    public int X;
    //    public int Y;
    //}
}
