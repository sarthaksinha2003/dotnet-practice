using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class ArrayListNonGeneric
    {
        public void display()
        {
            ArrayList list = new ArrayList();
            list.Add("Sarthak Sinha");
            list.Add(22);
            list.Add('M');

            for(int i=0;i<list.Count; i++) { 
                Console.WriteLine(list[i]);
            }

            foreach(var el in list) { 
                Console.WriteLine(el);
            }


        } 
    }
}
