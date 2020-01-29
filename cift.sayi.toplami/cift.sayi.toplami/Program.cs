using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cift.sayi.toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, toplam = 0; // değişkenlerin başlangıç değeri 0 olarak ayarlandı
            while (sayi % 2 == 0) // koşulda sayi değişkeninin çift olup olmadıgına bakılıyor
            {
                toplam = toplam + sayi;
                //sayi değikeninin değeri toplama ekleniyor
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Girilen Çift Sayıların Toplamı = " + toplam);
        }
    }
}
