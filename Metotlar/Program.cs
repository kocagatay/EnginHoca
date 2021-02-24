using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.stokAdet = 5;


            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.stokAdet = 3;

            Product[] products = new Product[] { product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.stokAdet);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-------------Metotlar---------------------");

            //instace - class örneği oluşturmak - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);


            sepetManager.Add2(urunAdi = "armut", aciklama = "sarı", fiyati = 10, 5);
            sepetManager.Add2(urunAdi = "ayva", aciklama = "sarı", fiyati = 10, 3);
            sepetManager.Add2(urunAdi = "kiraz", aciklama = "kırmızı", fiyati = 10, 1);



            Console.ReadLine();

        }
    }
}
