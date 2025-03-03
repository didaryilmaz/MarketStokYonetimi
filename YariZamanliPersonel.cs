using System;
namespace MarketStokYonetimi
{
    public class YariZamanliPersonel : Personel
    {
        public int CalistigiSaat { get; set; }
        public int SaatUcreti { get; set; }
        public int SatisSayisi { get; set; }

        double komisyon = 0.1;

        public override double Maas
        {
            get
            {
                return (CalistigiSaat * SaatUcreti) + SatisSayisi * komisyon; ;
            }
        }
        public override void PersonelBilgi()
        {
            Console.WriteLine(Isim + " " + SoyIsim + " " + Maas);
        }
    }
}
