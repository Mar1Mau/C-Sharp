using System;


namespace Calc
{
    static class Calc
    {

         static Calc()
        {
            Console.WriteLine(DateTime.Now);
        }

        

        public static int GetSub(int a, int b)
        {
            return a + b;
        }

        public static int GetSub(int a, int b, int c)
        {
            return a + b+c;
        }


        public static double GetSub(double a, double b)
        {
            return a + b;
        }

    }
}
