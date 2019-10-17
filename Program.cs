using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.WriteLine("Podaj swoje Imię: ");
            name = Console.ReadLine();
            Console.WriteLine(name + name);
            Console.ReadKey();
        }
    }
}
