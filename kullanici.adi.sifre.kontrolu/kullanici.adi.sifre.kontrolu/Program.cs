using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanici.adi.sifre.kontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            string kadi, sifre;
            Console.Write("Kullanıcı adını giriniz: ");
            kadi = Console.ReadLine();
            Console.Write("Kullanıcı şifresini giriniz: ");
            sifre = Console.ReadLine();

            if (kadi == "yersu" && sifre == "1234")
            {
                Console.Write("Kullanıcı girişi başarılıdır. ");
            }
            else
            {
                Console.Write("Kullanıcı girişi başarılı değildir. ");
            }
            Console.ReadKey();
        }
    }
}
