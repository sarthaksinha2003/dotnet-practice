using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Poly
    {
        string name;
        int age;
        public Poly(string s, int n)
        {
            name = s;
            age = n;
        }
        public string getDetails()
        {
            return name + " " + age;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
    }
}
