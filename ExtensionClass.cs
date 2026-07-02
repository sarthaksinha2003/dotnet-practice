using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class OldClass
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }
    public static class OldClassExtension
    {
        public static void Test3(this OldClass oldClass)
        {
            Console.WriteLine("Method three: " + oldClass.x);
        }
    }
}
