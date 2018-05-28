using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 6, e = 6;
            
            double c = 10, d = 20;
          

            Console.WriteLine(Calc.GetSub(c, d));
            Console.WriteLine(Calc.GetSub(a, b));
            Console.WriteLine(Calc.GetSub(a, b, e));
        }
    }
}
