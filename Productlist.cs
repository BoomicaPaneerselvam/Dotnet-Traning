using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productlist
{
    internal class Productlist
    {
        public static void Main()
        {
            string[][] pl = new string[3][];
            pl[0] = new string[4] { "Milk bikis", "Parle-G", "Hide&Seek", "Good day" };
            pl [1] = new string[5] { "Gone Mad", "Coffe Bite","Dairy Milk","Kit Kat","Munch" };
            pl[2] = new string[6] { "Apple Juice", "Rose Milk", "Coke", "Slice", "Pomegranate Juice", "Badam Milk" };
            for(int i = 0; i < pl.Length; i++)
            {
                for (int j = 0; j < pl[i].Length; j++)
                    Console.Write(pl[i][j] + "\t");
                    Console.WriteLine();
               
                    
            }

                
            
        }
    }
}
