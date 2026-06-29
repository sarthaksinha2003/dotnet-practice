using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class HASA
    {
        public void meth()
        {
            Address addr = new Address("B1-3029", "BBSR", "Odisha");
            Employee employee = new Employee(addr, 1001, "Ramesh",42);
            employee.display();
        }
    }
    class Address
    {
        public string addressLine;
        public string city;
        public string state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }

    }
    class Employee
    {
        public Address address;
        public int id;
        public String name;
        public int age;
        public Employee(Address address, int id, String name, int age)
        {
            this.address = address;
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            {
                Console.WriteLine("The ID number " + id + " Name is " + name + " and its addressLine is " + address.addressLine + ", city is " + address.city + " and state is " + address.state + ".");
            }
        }
        public int getAge()
        {
            return age;
        }
    }
}