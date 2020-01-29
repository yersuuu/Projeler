using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean.ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayıyı girin:");
            sayi=Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            bool durum2 = sayi < 0;
            Console.Write("Sayı pozitif mi{0}", durum1);
            Console.Write("Sayı 10'dan büyük mü {0}", durum2);
            Console.ReadKey();
        }
    }
}
