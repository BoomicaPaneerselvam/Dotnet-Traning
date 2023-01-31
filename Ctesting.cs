using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CORONA_TESTING
{
    internal class Ctesting
    {
        public void testing()
        {
            Console.WriteLine("Do you have travel history?:");
            var answer = Console.ReadLine();

            if (answer!="yes")            
                Console.WriteLine("Safe ! Not COVID-19 ");            
             else
            {
                Console.WriteLine("DO you have temperature?");
                var ans2 = Console.ReadLine();
                if(ans2!="yes")
                {
                    Console.WriteLine("Home Quarantine for 28 days");
                }
                else
                {
                    Console.WriteLine("Do you have cough/sneeze?");
                    var ans3 = Console.ReadLine();
                    if (ans3 != "yes")
                        Console.WriteLine("Quarentine fever medicine");
                    else
                        Console.WriteLine("Swab test");

                }
            }
           
        }
    }
    class Implementation
    {
        public static void Main()
        {
            Ctesting c1 = new Ctesting();
            c1.testing();
            

        }
    }
}
