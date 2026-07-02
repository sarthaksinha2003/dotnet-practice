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
            //ArrayList

            //ArrayList list = new ArrayList();
            //list.Add("Sarthak Sinha");
            //list.Add(22);
            //list.Add('M');

            //for(int i=0;i<list.Count; i++) { 
            //    Console.WriteLine(list[i]);
            //}

            //foreach(var el in list) { 
            //    Console.WriteLine(el);
            //}


            //HashTable

            //Hashtable ht = new Hashtable();
            //ht.Add("Name", "Sarthak Sinha");
            //ht.Add("Age", 21);

            //Console.WriteLine(ht.Count);
            //ht["Age"] = 22;

            //foreach(var el in ht.Keys)
            //{
            //    Console.WriteLine(el + " => " + ht[el]);
            //}


            //Non-Generic stack

            //Stack st = new Stack();
            //st.Push("Sarthak");
            //st.Push('M');
            //st.Push(22);

            //foreach(var el in st)
            //{
            //    Console.WriteLine(el);
            //}

            //int size = st.Count;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(st.Pop());
            //}

            //Non - Generic Queue

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue("Winner");
            q.Enqueue("Takes it");
            q.Enqueue("All");

            Console.WriteLine("This is For Each loop");
            foreach (var el in q) { 
                Console.WriteLine(el);
            }

            int size = q.Count;

            Console.WriteLine("This is Normal For loop");
            for(int i = 1;i<= size; i++) {
                Console.WriteLine(q.Dequeue());
            }

        } 
    }
}
