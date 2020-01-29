using System;

namespace DonguKomutları

{

    class Program

    {

        static void Main(string[] args)

        {

            int a = 5;

            while (a < 11)

            {

                Console.WriteLine("{0}", a);

                a++;

            }

            do

            {

                Console.WriteLine("do while : {0}", a);

            } while (a < 4);

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("for : {0}", i);

            }

            for (int i = 0; i < 10; i++)

           {

            for (int j = 0; j < 11; j++)

            {


             }

            }

            Console.ReadKey();

        }

    }

}