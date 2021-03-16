using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            {
                Console.WriteLine("The even numbers are: " );
            }

            for (int i = 1; i<=100;i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
