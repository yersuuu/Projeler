using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int boy, kilo;
            boy = Convert.ToInt32(Console.ReadLine());
            kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz:");
            Console.WriteLine("Kilonuzu giriniz:");
            if (boy<170 && kilo>100)
            {
                Console.WriteLine("1. elemeyi geçemediniz");
            }
            else
            {
                Console.WriteLine("tebrikler 1. elemeyi geçtiniz");
                Console.ReadKey();
            }
            }
        }
    }

