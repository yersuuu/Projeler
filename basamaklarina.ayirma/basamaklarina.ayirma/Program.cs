using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basamaklarina.ayirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, yüzler, onlar, birler;
            Console.WriteLine("sayiyi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            yüzler = sayi / 100;
            sayi = sayi - (yüzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi;
            Console.WriteLine("Yüzler basamağı {0}", yüzler);
            Console.WriteLine("Onlar basamağı {0}", onlar);
            Console.WriteLine("Birler basamağı {0}", birler);
            Console.ReadKey();

        }
    }
}
