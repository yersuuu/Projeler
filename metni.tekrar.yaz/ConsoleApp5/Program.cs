using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metni Gir : ");
            string metin = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadKey();
        }
    }
}
