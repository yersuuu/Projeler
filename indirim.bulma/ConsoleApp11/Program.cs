using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, odenecek, indirim;
            Console.WriteLine("alınan malın fiyatı= ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x<100)
            {
                indirim = (x * 0.5);
                odenecek = x - (x * 0.5);
            }
            else
            {
                indirim = (x * 0.10);
                odenecek = x - (x * 0.10);
            }
            Console.ReadKey();
        }
    }
}
