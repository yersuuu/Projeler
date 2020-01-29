using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indirim.hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, odenen, indirim;
            Console.WriteLine("alış-veriş tutarını giriniz:");
            x = Convert.ToDouble(Console.ReadLine());
            if (x<=100)
            {
                Console.WriteLine("indirim için yeterli tutar kullanılmamıştır.");
                Console.ReadLine();
            }
            else
            {
                indirim = (x * 0.1);    
                odenen = x - indirim;
                Console.WriteLine("odenen: " + odenen);
                Console.WriteLine("indirim: " + indirim);

                Console.ReadLine();
            }
        }
    }
}
