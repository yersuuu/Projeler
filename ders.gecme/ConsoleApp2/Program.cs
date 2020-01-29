using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                int vize1, vize2, final;
                Console.WriteLine("1.Vize notunu giriniz:");
                vize1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Vize notunu giriniz:");
                vize2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Final notunu giriniz:");
                final = Convert.ToInt32(Console.ReadLine());

                if (vize1 + vize2 >= 50)
                {
                    Console.WriteLine("ders başarıyla geçildi.");
                }
                else
                {
                    Console.WriteLine("ders başarısızlıkla sonuçlandı.");
                }


                Console.ReadKey();


            }
        }

        public int Topla(List<int> sayilar)
        {
            int sonuc = 0;

            foreach (var sayi in sayilar)
            {
                if (sayi < 0 || sayi == 0)
                {
                    continue;
                }

                sonuc += sayi;
            }

            return sonuc;
        }
    }
}

