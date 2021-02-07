using System;
using System.Collections.Generic;

namespace MyDictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciListesi = new Dictionary<int, string>();

            Console.WriteLine("--- Eklenecek Ögrencinin ---");
            int ogrenciNo = 1;
             OGRENCİEKLE:
            Console.Write("Adı Soyadı : ");
            string ogrenci = Console.ReadLine();
            ogrenciListesi.Add(ogrenciNo, ogrenci);

            Console.WriteLine("Eklenecek kişi var mı ? ");
            Console.WriteLine("Eğer varsa evet için E tuşuna, yoksa hayır için H tuşuna basınız! ");

            char cevap = Convert.ToChar(Console.ReadLine());

            if (cevap == 'E' || cevap == 'e' )
            {
                ogrenciNo++;
                goto OGRENCİEKLE;

            }
            else if (cevap == 'H' || cevap == 'h')
            {
                Console.WriteLine("Öğrenci Sayısı : " + ogrenciNo );
                Console.WriteLine("Öğrenciler : ");
                foreach (var kisiler in ogrenciListesi)
                {
                    Console.WriteLine(kisiler);
                }
            }
           

                
           

            
        }
    }
}
