using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   // naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Adi);

        }
        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdet)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);

        }


    }
}
