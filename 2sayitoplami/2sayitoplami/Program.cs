using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sayitoplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("Birinci sayiyi girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayiyi girin:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("{0}+{1}={2}",sayi1,sayi2,toplam);
            Console.ReadKey();
        }
    }
}
