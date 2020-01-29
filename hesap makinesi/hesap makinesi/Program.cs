using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            public int Topla(List<int> sayilar)
            {
                int sonuc = 0;

                foreach (var sayi in sayilar)
                {
                    if (sayi < 0 || sayi == 0)
                    {
                        continue;
                    }

                    sonuc += sayi;
                }

                return sonuc;
            }
        }
    }
}
