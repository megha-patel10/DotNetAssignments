using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practical 1");
            pattern1(); // call pattern 1
            pattern2(); // call pattern 2
            pattern3(); // call pattern 3
        }
        static void pattern1()
        {
             for(int i=0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        static void pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        static void pattern3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
