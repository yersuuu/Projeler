using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            string kadi, sifre;
            Console.WriteLine("Kullanıcı adını giriniz:");
            kadi=Console.ReadLine();
            Console.WriteLine("Kullanıcı şifresini giriniz:");
            sifre = Console.ReadLine();
            if (kadi=="Yersu Yanık" && sifre=="123")
            {
                Console.WriteLine("Kullanıcı girişi başarılıdır.");
            }
            else
            {
                Console.WriteLine("Kullanıcı girişi başarılı değildir.");
            }
            Console.ReadKey();
        }
    }
}
