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
            string sayi1, sayi2, islem;
            int s1, s2;

            Console.WriteLine("İlk Sayısı Giriniz ?");
            sayi1 = Console.ReadLine();
            s1 = Int32.Parse(sayi1);
            Console.WriteLine("İkinci Sayısı Giriniz ?");
            sayi2 = Console.ReadLine();
            s2 = Int32.Parse(sayi2);
            Console.WriteLine("İşlemi Giriniz [Toplama: + , Çıkarma: - , Çarpma: * , Bölme: / ]");
            islem = Console.ReadLine();

            switch (islem)
            {
                case "+": sonuc = s1 + s2; break;
                case "-": sonuc = s1 - s2; break;
                case "/": sonuc = (double)s1 / (double)s2; break;
                case "*": sonuc = s1 * s2; break;
                default: break;
            }
            Console.WriteLine();
            Console.WriteLine("Çıkmak İçin Bir Tuşa Basın !");
            Console.ReadKey();

        }
    }
}
