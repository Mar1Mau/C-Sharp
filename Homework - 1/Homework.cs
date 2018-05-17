using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("enter number [" + i + "] :");
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Finished input... ");


            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                int b = array[i+1];
                int sum = a + b;
                if (sum % 2 != 0)
                {
                    Console.WriteLine("Result: "+a +" , "+b);
                }

            }

            Console.ReadLine();


           
        }
    }
}
