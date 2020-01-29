using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaman.yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            Console.Write("Tarih ve Saat:{0}", zaman);
            Console.ReadKey();

        }
    }
}
