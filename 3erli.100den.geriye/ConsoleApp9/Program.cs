using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<=100)
            {
                if (x % 3 == 0)
                {


                    Console.WriteLine(x);
                }
                x++;
            }
            Console.ReadKey();
        }
    }
}
