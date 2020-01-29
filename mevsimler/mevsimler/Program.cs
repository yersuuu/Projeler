using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mevsimler
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Lütfen mevsim giriniz: ");
            mevsim = Console.ReadLine();
            if (mevsim == "kış")
            {
                Console.WriteLine("Aralık,Ocak,Şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("Mart,Nisan,Mayıs");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Eylül,Ekim,Kasım");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine("Haziran,Temmuz,Ağustos");
            }
            Console.ReadKey();
        }
    }
}
