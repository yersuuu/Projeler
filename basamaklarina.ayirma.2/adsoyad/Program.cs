using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adsoyad
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, birler, onlar, yuzler;
            Console.WriteLine("3 basamaklı sayiyi giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi;
            Console.WriteLine("Yüzler basamağı : {0}", yuzler);
            Console.WriteLine("Onlar basamağı : {0}", onlar);
            Console.WriteLine("Birler basamağı : {0}", birler);
            Console.ReadKey();
        }
    }
}
