using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicationtable
{
    internal class Multiplication_table
    {
         
            public Multiplication_table(int num)
            {
                for (int i = 1; i <= 20; i++)
                {
                    int ans = num * i;
                    Console.WriteLine( num+"*"+i + "=" + ans);
                }
            }
            public static void Main()
            {
            Console.WriteLine("Enter number");
           int n = Convert.ToInt32(Console.ReadLine());
            Multiplication_table mt = new Multiplication_table(n);
            }
        }

    }
