using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ters;
            Console.WriteLine("Numara giriniz:");
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                ters = ters * 10;
                ters = ters + num % 10;
                num = num / 10;
            }
            Console.WriteLine("sayının tersi:" + ters);
            Console.ReadLine();

        }
    }
}
