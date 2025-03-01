using System;
namespace MarketStokYonetimi
{
    public abstract class Personel
    {
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public int satisSayisi { get; set; }

        public abstract double maas { get; }
        public abstract void PersonelBilgi();

    }
}
