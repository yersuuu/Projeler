using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while.dongu
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            BASADON:
            Console.WriteLine("Bir sayı giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());
            while (x %2==0)
            {
                Console.WriteLine("Çift sayı girdiniz");
                Console.ReadKey();
            }
            Console.WriteLine("Tek sayı girdiniz");
            goto BASADON;
            Console.ReadKey();
        }
    }
}
