using System;
using System.Collections.Generic;

namespace MarketStokYonetimi
{
    public static class PersonelIslemleri
    {
        static List<Personel> personels = new List<Personel>();

        public static void PersonelEkle(Personel personel)
        {
            personels.Add(personel);
        }

        public static void PersonelListele()
        {
            foreach (var personel in personels)
            {
                Console.WriteLine(personel.Isim + " " + personel.SoyIsim);
            }
        }
    }
}
