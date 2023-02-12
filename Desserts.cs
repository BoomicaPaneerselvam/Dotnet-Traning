using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Desserts
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Bread Halwa");
            list.Add("Laddoo");
            list.Add("Julab Jammun");
            list.Add("Jaggery");
            list.Add("Black Forest");
            list.Add("Choco Truffle");

            FileStream fw = new FileStream(@"C:\Traning\visualstudio\Task\task6\Desserts.txt", FileMode.OpenOrCreate, FileAccess.Write);
             StreamWriter sw= new StreamWriter(fw);
            foreach(object o in list)
            {
                sw.WriteLine(o.ToString());
            }
            sw.Flush();
            sw.Close();
            fw.Close();
            FileInfo Info = new FileInfo("C:\\Traning\\visualstudio\\Task\\task6\\Desserts.txt");
            Console.WriteLine("File creation date and time:"+Info.CreationTime);
            Console.WriteLine("File  length:"+Info.Length);
        }

    }
}
