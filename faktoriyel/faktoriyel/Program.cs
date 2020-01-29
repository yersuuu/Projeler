using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            Console.WriteLine("Faktöriyeli alınacak sayıyı giriniz:");
            i=Convert.ToInt32(Console.ReadLine());
            int faktoriyel=1;
            while ( i>1)
            {
                faktoriyel = faktoriyel * i;
                i--;
            }
            Console.Write(faktoriyel);
            Console.ReadKey();

        }
    }
}
