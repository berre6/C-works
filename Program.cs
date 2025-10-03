// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        // Büyük olan sayıyı bul
        int buyukSayi = (sayi1 > sayi2) ? sayi1 : sayi2;

        // Tek mi çift mi kontrol et
        if (buyukSayi % 2 == 0)
        {
            Console.WriteLine("Büyük sayı {0} ve çift.", buyukSayi);
        }
        else
        {
            Console.WriteLine("Büyük sayı {0} ve tek.", buyukSayi);
        }
    }
}

