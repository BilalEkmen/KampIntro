using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama İçin Temel Kurs";
            string kurs3 = "Java";

            //array -> dizi

            string[] kurslar = new string[] { 
                "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlama İçin Temel Kurs", 
                "Java", 
                "Phyton"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("----foreach----");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Döngü Bitti");
        }
    }
}
