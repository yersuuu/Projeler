using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haftanin.gunleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("1 ile 7 arasında bir rakam giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1: Console.Write("Gün = Pazartesi");
                    break;
                case 2: Console.Write("Gün = Salı");
                    break;
                case 3: Console.Write("Gün = Çarşamba");
                    break;
                case 4: Console.Write("Gün = Perşembe");
                    break;
                case 5: Console.Write("Gün = Cuma");
                    break;
                case 6: Console.Write("Gün = Cumartesi");
                    break;
                case 7: Console.Write("Gün = Pazar");
                    break;
            }
            Console.ReadKey();
        }
    }
}
