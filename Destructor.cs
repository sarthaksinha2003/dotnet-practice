using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~Destructor()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }

        public int num()
        {
            return 0;
        }
    }
}
