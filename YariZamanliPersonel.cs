using System;
namespace MarketStokYonetimi
{
    public abstract class YariZamanliPersonel : Personel
    {
        public int calistigiSaat { get; set; }
        public int saatUcreti { get; set; }
        double komisyon = 0.1;

        public override double maas
        {
            get
            {
                return (calistigiSaat * saatUcreti) + satisSayisi * komisyon; ;
            }
        }
        public override void PersonelBilgi()
        {
            Console.WriteLine(isim + " " + soyIsim + " " + maas);
        }
    }
}
