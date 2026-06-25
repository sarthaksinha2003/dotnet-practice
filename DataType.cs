using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject{
    internal class DataType{
        public static void dataType() {
            //Value Types

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b); 

            //Reference Types

            string s1 = "Sarthak";
            string s2 = s1;
            s2 = "Sinha";
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
