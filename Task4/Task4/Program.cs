using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=100, SumofEven = 0, SumofOdd = 0;
           

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    SumofEven = SumofEven + i;

                }
                else if (i % 2! = 0)
                {
                    SumofOdd = SumofOdd + i;
                }
                Console.WriteLine("Sum of Even Number: "+SumofEven);
                Console.WriteLine("Sum of Odd Number: " + SumofOdd);

            }
        }
    }
}
