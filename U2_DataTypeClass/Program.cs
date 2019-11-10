using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_DataTypeClass
{
    class Person
    {
        protected string name;
        protected int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Employee : Person
    {
        public Employee(string n, int a) : base(n, a)
        {
            // Code for Employee
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Yeap Chor Ee", 85);
        }
    }
}
