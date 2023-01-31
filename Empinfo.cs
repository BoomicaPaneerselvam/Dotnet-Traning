using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Empinfo
    {
        public Empinfo()
        {
            Console.WriteLine("Enter your Employee ID:");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            var gend = Console.ReadLine();
            Console.WriteLine("Enter your year of Experience:");
            int eof= Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Employee ID is" + empid);
            Console.WriteLine("Employee Name is" + name);
            Console.WriteLine("Employee Gender is" + gend);
            Console.WriteLine("Employee year of experience is:" + eof);
           
        }
        
    }
     class Calculate:Empinfo
    {
        public void sales_marketing(int sal)
        {
            
            Console.WriteLine("Employee salary for Sales and Marketing is:" + (sal+(sal*0.2)));
        }
        public void production(int sal)
        {
           
            Console.WriteLine("Employee salary for Production is:" + (sal + (sal * 0.1)));
        }
    }

    class Implementation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your role\n 1.sales or Marketing\n 2.production.");
            int role =Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("Enter your Salary:");
            int sal = Convert.ToInt16(Console.ReadLine());
            Calculate cal=new Calculate();
           
            cal.production(sal);

            switch (role)
            {
                case 1:
                    cal.sales_marketing(sal);
                    break;
                case 2:
                    cal.production(sal);
                    break;
                default:
                    Console.WriteLine("OOPS!...you have  entered a wrong choice");
                    break;

            }

        }
    }
}
