using System;

namespace MyFirstProject
{
    class Inheritance { 
    
        public Inheritance() {
            Console.WriteLine("This is not going to works");
        }
        public Inheritance(string s) {
            Console.WriteLine(s);
        }
        public void Method1()
        {
            Console.WriteLine("Blue Meth 1");
        }
        public void Method2()
        {
            Console.WriteLine("Blue Meth 2");
        }
    }
    class child : Inheritance
    {
        public child() : base("Sarthak"){ }
        public void meth(child obj)
        {
            obj.Method1();
            obj.Method2();
        }
    }   
}
