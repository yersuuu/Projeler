using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd.alan.cevre
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisakenar, uzunkenar, alan, cevre;
            Console.Write("Kısa kenar uzunluğunu giriniz :");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenar uzunluğunu giriniz :");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            alan = kisakenar * uzunkenar;
            cevre = 2 * (kisakenar + uzunkenar);
            Console.WriteLine("Dikdörtgenin Alanı = {0},Çevresi={1}", alan, cevre);
            Console.ReadKey();
        }
    }
}
