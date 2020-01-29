using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp4
{
    class Program
    {
        private static int x = 11;
        private static Timer sayac = new Timer();
        static void Main(string[] args)
        {
            sayac.Interval = 1000;
            sayac.Elapsed += gerisayim;
            sayac.Start();
            Console.ReadKey();
        }
        private static void gerisayim (object source,System.Timers. ElapsedEventArgs e)
        {
            x--;
            Console.Clear();
            Console.Write(x);
            if (x==0)
            {
                sayac.Stop();
                Console.WriteLine("Süre Bitti.");
            }
        }
    }
}