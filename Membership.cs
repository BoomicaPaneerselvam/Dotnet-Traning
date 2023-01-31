using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    interface Award_winners
    {
        void silver_winners();
        void Gold_winners();
        void Platinum_winners();
    }
    class Membership_package : Award_winners
    {
        public void silver_winners()
        {
            Console.WriteLine("Silver \n 3 Days accomadation at resort");
        }

        public void Gold_winners()
        {
            Console.WriteLine("Gold \n 5 days accomadation at resort \n 2 Dinners on the house ");
        }
        public void Platinum_winners()
        {
            Console.WriteLine("Platinum \n 7 days accomadation at resort \n 5 Dinners on the house");
        }



        public static void Main(string[] args)
        {
            Membership_package mp = new Membership_package();
            mp.silver_winners();
            mp.Gold_winners();
            mp.Platinum_winners();

        }
    }
}
    


