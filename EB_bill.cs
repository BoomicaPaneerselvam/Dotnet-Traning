using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ebill
{
    internal class EBbill
    {
        public void Unitcaculation(int units)
        {
            int payment;
            if (units <= 200)
            {
                payment = 2 * units;
                Console.WriteLine("Your EB_bill is {0}", payment);
            }
            if (units > 200 && units < 350)
            {
                payment = 200 * 2 + (units - 200) * 3;
                Console.WriteLine("Your EB_bill is {0}", payment);
            }
            if (units > 350 && units < 500)
            {
                payment = 200 * 2 + 150 * 3 + (units - 350) * 5;
                Console.WriteLine("Your EB_bill is {0}", payment);
            }

        }
        public static void Main(string[] args)
        {
            EBbill bill = new EBbill();
            Console.WriteLine("Enter no of units");
            int units = Convert.ToInt32(Console.ReadLine());
            bill.Unitcaculation(units);

        }

    }
}
