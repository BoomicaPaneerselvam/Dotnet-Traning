using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mark_array
{
    internal class Mark
    {
    public static void Main()
        {
            Console.WriteLine("Enter your number of subject");
            int ns=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Mark:");            
             int[] marks = new int[ns];
             int sum = 0;
            for (int i=0;i<ns;i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + marks[i];
                //Console.WriteLine(sum);
            }
            Console.WriteLine("Total Marks you obtained is:" +sum);
            float percentage = (sum /500)*100;
            Console.WriteLine("Percentage you secured is:" + percentage+"%");


        }
    }
}
