using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int kategoriNumarası = 10;
            double kategoriFiyatı = 99.99;
            bool kategoriDurumu = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi");   
            }



            if (kategoriDurumu == true)
            {
                Console.WriteLine("Stokta Ürün var");
            }
            else
            {
                Console.WriteLine("Stokta Ürün yok");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
