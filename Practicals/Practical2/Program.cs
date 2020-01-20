using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;

            Console.WriteLine("What's your good name?");
            name = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            country = Console.ReadLine();

            Console.WriteLine("Hi ," + name + " from " + country);
            Console.Read();
        }
    }
}
