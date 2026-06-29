using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject {
    internal class ISA {
        public int l;
        public int b;
        public int area() {
            return l * b;
        }
        public int perimeter() {
            return 2 * (l + b);
        }
    }
    class Cuboid : ISA{
        public int h;
        public Cuboid(int l,int b,int h)
        {
            this.l = l;
            this.b = b;
            this.h = h;
        }
        public int volume()
        {
            return l * b * h;
        }
    }
}
