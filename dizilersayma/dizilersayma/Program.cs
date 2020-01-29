using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilersayma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + "Öğrencinin Adı:");
                isim[i] = Console.ReadLine();
                Console.WriteLine(i + 1 + "Sınav1:");
                s1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i + 1 + "Sınav2:");
                s2[i] = Convert.ToInt32(Console.ReadLine());
                ort[i] = (s1[i] + s2[i]) / 2;
            }
            Console.Write("Öğrenci Sınav1 Sınav2 Ortalama");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" " + isim[i] + " " + s1[i] + " " + s2[i] + " " + ort[i]);
            }
            Console.ReadKey();
        }
    }
}
