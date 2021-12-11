using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün ismi" + " : " + urun.Adi);
                Console.WriteLine("Ürün fiyatı" + " : " + urun.Fiyati);
                Console.WriteLine("Ürün açıklaması" + " : " + urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------------Metodlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------");
                    

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 2);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 15);




        }
    }
}





//Dont Repeat Yourself - DRY - Clean Code - Best Practice



