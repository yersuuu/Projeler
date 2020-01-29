using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgelesayi.toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ortalama;
            Console.WriteLine("vize notunu giriniz:");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunu giriniz:");
            final = Convert.ToInt32(Console.ReadLine());
            ortalama = (vize * 0.4) + (final * 0.6);
            if (ortalama<35 || final<35)
            {
                Console.WriteLine("BAŞARISIZ");
            }
            else
            {
                Console.WriteLine("GEÇTİ");
            }
            Console.ReadKey();
        }
    }
}
