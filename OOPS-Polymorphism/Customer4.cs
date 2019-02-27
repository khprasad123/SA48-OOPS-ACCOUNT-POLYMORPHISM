using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPS_Polymorphism
{
    class Customer4
    {
        static int count = 1;
        int id=1;
        string name;
        string address;
        int age;

        public Customer4() { id +=count++; getValues(); } //default
        
        public Customer4(string name, string address, int age)
        {
            id += count++;
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public int CID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void getValues()
        {
            Console.Write("\n\tEnter your name : ");
            name = Console.ReadLine();
            Console.Write("\n\tEnter your address : ");
            address = Console.ReadLine();
            Console.Write("\n\tEnter your Age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("\n\n");
        }
        public void Display()
        {
            Console.WriteLine("\tCust ID: " + id  +"\t"+ name);
        }
    }

}
