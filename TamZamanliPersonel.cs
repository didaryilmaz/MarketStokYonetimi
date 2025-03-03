using System;
namespace MarketStokYonetimi
{
    public class TamZamanliPersonel : Personel
    {
        public double TabanMaas { get; set; }

        public override double Maas
        {
            get
            {
                double prim;

                if (SatisSayisi < 100000)
                {
                    prim = SatisSayisi * 0.01;
                }
                else if (SatisSayisi < 200000 && SatisSayisi > 100000)
                {
                    prim = SatisSayisi * 0.03;
                }
                else
                {
                    prim = SatisSayisi * 0.05;
                }
                return TabanMaas + prim;
            }
        }

        public override void PersonelBilgi()
        {
            Console.WriteLine(Isim + " " + SoyIsim + " " + Maas);
        }
    }
}
