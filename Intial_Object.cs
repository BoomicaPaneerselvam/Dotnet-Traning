using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Intial_Object
    {
        public int age;
        public string name;
        public Intial_Object(int age, string name)
        {
            this.age = age;
            this.name = name;   
        }
        public void show()
        {
            Console.WriteLine("Name is {0}\nAge is {1}\n",name,age);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Intial_Object ib = new Intial_Object(age,name);
            ib.show();
        }

    }
}
