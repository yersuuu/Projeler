using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuramayi.ters.cevirme

    {
        class Program
        {
            static void Main(string[] args)
            {
                int num, ters = 0;
                Console.WriteLine("Bir Numara Girin:");
                num = int.Parse(Console.ReadLine());
                while (num != 0)
                {
                    ters = ters * 10;
                    ters = ters + num % 10;
                    num = num / 10;
                }
                Console.WriteLine("Sayının tersi : " + ters);
                Console.ReadLine();
            }
        }
    }

