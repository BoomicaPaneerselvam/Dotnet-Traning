using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Age_and_name
{
    internal class Age_name
    {
        public void Agetimename()
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            var name = Console.ReadLine();
            for (int i = 0; i < age; i++)
                Console.WriteLine(name);
        }
    
    }
    class Implementation
    {
        public static void Main()
        {
            Age_name obj = new Age_name();
            obj.Agetimename();

        }
       


    }
}
