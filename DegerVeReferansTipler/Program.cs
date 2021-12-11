using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayiar1 = new int[] { 10, 20, 30 };
            int[] sayiar2 = new int[] { 100, 200, 300 };
            sayiar1 = sayiar2;
            sayiar2[0] = 999;
            //sayilar1[0] ?? 999
        }
    }
}
