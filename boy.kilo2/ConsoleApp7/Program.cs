using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int boy, kilo;
           

            Console.WriteLine("Boyunuzu giriniz:");
            boy = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Kilonuzu giriniz:");
            kilo = Convert.ToInt32(Console.ReadLine());
            if (boy < 170 && kilo > 100)
            {
                Console.WriteLine("HAYIR");
            }
            else
            {
                Console.WriteLine("EVET");
                Console.ReadKey();
            }
        }
    }
}
