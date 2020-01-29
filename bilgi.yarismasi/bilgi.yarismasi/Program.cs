using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgi.yarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.WriteLine("Adınızı giriniz:");
            ad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyadınızı giriniz:");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cevapları büyük harfle yazınız!");
            Console.WriteLine("Seçenekleri görmek ve devam etmek için her adımdan sonra ENTER tuşuna basın!");
            Console.ReadLine();
            int dogru, yanlis, puan;
            dogru = 0;
            yanlis = 0;
            puan = 0;
            string s1;
            Console.WriteLine("Soru 1 : En çok kazanan Youtuber kimdir?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine(" A-Danla Bilic\n B-Cansu Akın\n C-Ceren Ceylan\n D-Duygu Özaslan\n");
            c1 = Console.ReadLine();
            if (c1=="A")
            {
                dogru = dogru + 1;
                puan = puan + 10;
                Console.WriteLine("Tebrikler Doğru cevap. Devam için enter tuşu");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef yanlış cevap. ");
                Console.ReadLine();
            }
            string s2;
            Console.WriteLine("Soru 2 : Aşağıdaki Youtuberlardan hangisi Youtube hesabını kapatmıştır?");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine(" A-Şeyma Subaşı\n B-Ece Targıt\n C-Enes Batur\n D-Sebile Ölmez\n");
            c2 = Console.ReadLine();
            if (c2=="B")
            {
                dogru = dogru + 1;
                puan = puan + 10;
                Console.WriteLine("Tebrikler Doğru cevap. Devam için enter tuşu");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef yanlış cevap. ");
                Console.ReadLine();
            }
            string s3;
            Console.WriteLine("Soru 2 : Aşağıdaki Youtuberlardan hangisi diğerlerinden farklı bir içerik üreticisidir?");
            s3 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine(" A-Cansu Dengey\n B-Ceren Ceylan\n C-Danla Bilic\n D-Barış Özcan\n");
            c3 = Console.ReadLine();
            if (c3 == "D")
            {
                dogru = dogru + 1;
                puan = puan + 10;
                Console.WriteLine("Tebrikler Doğru cevap. Devam için enter tuşu");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef yanlış cevap. ");
                Console.ReadLine();
            }
            Console.WriteLine("Adınız:" + ad);
            Console.WriteLine("Soyadınız:" + soyad);
            Console.WriteLine("Doğru sayısı:" + dogru);
            Console.WriteLine("Yanlış sayısı:" + yanlis);
            Console.WriteLine("Toplam puan:" + puan);
            Console.ReadKey();

        }
    }
}
