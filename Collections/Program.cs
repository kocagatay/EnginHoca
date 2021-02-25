using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List ve Array arasındaki fark. Array'e ekleme yapamıyorsun referans tip oluyor adres değişmiş oluyor
            // List de is ekleme yapılabiliyor adres olarak baz almıyor. Adres de 101 102 dediği.

            List<string> isimler2 = new List<string> {"Ahmet","Mehmet","Halil","Mert" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            Console.ReadLine();
        }
        
    }
}
