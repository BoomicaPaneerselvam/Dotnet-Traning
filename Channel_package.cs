using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel_package
{
    internal class Channel_package
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter your package A or B or C");
            var package = Console.ReadLine();
            switch (package)
            {
                case "package A":
                    {
                        Console.WriteLine("South Special");
                        Console.WriteLine("Children's Club");
                        Console.WriteLine("Movies");
                        Console.WriteLine("Rate:₹250");
                        break;
                    }
                case "package B":
                    {
                        Console.WriteLine("News");
                        Console.WriteLine("Sports");
                        Console.WriteLine("Movies");
                        Console.WriteLine("Regional-2");
                        Console.WriteLine("Rate:₹450");
                        break;
                    }
                case "package C":
                    {
                        Console.WriteLine("Discovery");
                        Console.WriteLine("History");
                        Console.WriteLine("National");
                        Console.WriteLine("Rate:₹350");
                        break;
                    }
                    

            }


        }
    }
}
