using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal.sayi.bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            public static bool asalmi(int sayi)
            {
                bool durum = false;
                int kontrol = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i==0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol==1)
                {
                    durum = false;
                }
                else
                {
                    durum = true;
                }
                return;
            }
            static void Main(string[] args)
            {
                int sayac = 0;
                Console.WriteLine("Sayiyi girin:");
                int s = Convert.ToInt32(Console.ReadLine());
                if (asalmi(s))
                {
                    Console.WriteLine("{0} ASAL", s);
                }
                else
                {
                    Console.WriteLine("{0} ASAL DEGIL", s);
                }
                Console.WriteLine("=============");
                Console.WriteLine("Sonraki 5 Asal Sayi");
                Console.WriteLine("=============");
                while (true)
                {
                    s++;
                    if (asalmi(s)==true)
                    {
                        Console.WriteLine("{0} sayısı asal", s);
                        sayac++;
                        if (sayac==5)
                        {
                            break;
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
