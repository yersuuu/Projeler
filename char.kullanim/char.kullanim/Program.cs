using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char.kullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinsiyet;
            Console.WriteLine("Cinsiyet giriniz:");
            cinsiyet = Convert.ToInt32(Console.ReadLine());
            if (cinsiyet = "e" || "E")
            {
                Console.Write("Cinsiyetiniz erkektir.");
            }
            else if (cinsiyet = "k" || "K") 
            {
                Console.Write("Cinsiyetiniz kadındır.");
            }
        }
    }
}
