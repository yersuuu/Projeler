using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uretilensayi = rnd.Next(20, 35);
            int sayi;
            int hak = 5;
            do
            {
                Console.WriteLine("20 ve 35 arasındaki değerlerde bir tahminde bulununuz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (hak == 0)
                {
                    Console.WriteLine("tahmin hakkınız tükenmiştir");
                }
                hak--;

                if (sayi == uretilensayi)
                {
                    Console.WriteLine("doğru tahmin");
                }

                else if (sayi < uretilensayi)
                {
                    Console.WriteLine("sayi değerini artırın");
                }
                else
                {
                    {
                        Console.WriteLine("sayi degerini azaltın");
                    }
                }
                while (sayi != uretilensayi && hak != 0) ;
                {
                    Console.ReadKey();
                }
            } while (true);

    {

            }

    }
    } }
