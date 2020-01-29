using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgeledegisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uretilensayi = rnd.Next(25, 59);
            int sayi;
            int hak=5;
            do
            {
                Console.WriteLine("2 basamaklı bir tahminde bulununuz:");
                sayi = Convert.ToInt32(Console.ReadLine());
               
                hak--;

                if (hak == 1)
                {
                    Console.WriteLine("SON TAHMİN HAKKINIZ");
                }


                else if (hak == 0)
                {
                    Console.WriteLine("Tahmin başarısız.Tekrar deneyin");
                    Console.ReadKey();
                }

                if (sayi<uretilensayi)
                {
                    Console.WriteLine("Sayi değerini artırınız!");
                }
                else if (sayi>uretilensayi)
                {
                    Console.WriteLine("Sayi değerini azaltınız!");
                }
                else
                {
                    Console.WriteLine("tahmininiz doğru.Tebrikler...");
                    Console.ReadKey();

                }
            } while (sayi!=uretilensayi&&hak!=0);
        }
    }
}
