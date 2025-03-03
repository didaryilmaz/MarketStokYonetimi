using System;
namespace MarketStokYonetimi
{
    public abstract class Personel
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public int SatisSayisi { get; set; }

        public abstract double Maas { get; }
        public abstract void PersonelBilgi();

    }
}
