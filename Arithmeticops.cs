using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Arithmeticops
    {
        public abstract void arithmeticoperation();

    }
    class  Calculator:Arithmeticops
    {
        public override void arithmeticoperation()
        {
            Console.WriteLine("Enter two number for calculation ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of two number is:" + (a + b));
            Console.WriteLine("Subtraction of two Number is:" + (a - b));
            Console.WriteLine("Multiplication of two number is:" + (a * b));
            Console.WriteLine("Division of two Number is:" + (a / b));
        }
        public static void Main(string[] args)
        {
            Calculator cal= new Calculator();
           cal.arithmeticoperation();
        }
    }
}
