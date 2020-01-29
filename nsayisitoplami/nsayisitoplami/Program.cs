#include <stdio.h>
#include <conio.h>

int main()
{
    int i, n, sonuc;
    // degişkenler tanımlanıyor.

    // integer'e karşılık prinf ve scanf'te %d kullanırlır.

    printf("Bir sayi giriniz :");
    //Kullanıcıdan değerler alınıyor..

    scanf("%d", &n);
    // %d sayının tipini ifade ediyor. & sayısal olanlarda giriliyor.
    //  String bir ifade kullanmak istedeğimizde & işaretini kullanmıyoruz.
    //

    sonuc = 0;

    for (i = 1; i <= n; i++)

        sonuc = sonuc + i;

    printf("istediginiz toplam: %d ", sonuc);
    // sonuç ekrana yazdırılıyor.. 
    // %f virgüllü sayılar
    // %s string ifadelerinde kullanıyoruz.

    getch();
    // kapanmasını engelliyor..
}