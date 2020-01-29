using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<0)
            {
                Console.WriteLine("Sayi negatiftir");
            }
            else if (sayi>0)
            {
                Console.WriteLine("Sayi pozitiftir");
            }
            else if (sayi==0)
            {
                Console.WriteLine("Sayi sıfırdır");
            }
            Console.ReadKey();

        }
    }
}
