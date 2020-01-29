using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cumledeki.kelime.sayisini.bulmak
{
    class Program
    {
        static void Main(string[] args)
        {

 string cumle;
            Console.Write("Cumleyi Girin : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine(kelimeler.Length);
            Console.ReadKey();
        }
    }
}
