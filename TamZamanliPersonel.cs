using System;
namespace MarketStokYonetimi
{
    public class TamZamanliPersonel : Personel
    {
        public double tabanMaas { get; set; }

        public override double maas
        {
            get
            {
                double prim;

                if (satisSayisi < 100000)
                {
                    prim = satisSayisi * 0.01;
                }
                else if (satisSayisi < 200000 && satisSayisi > 100000)
                {
                    prim = satisSayisi * 0.03;
                }
                else
                {
                    prim = satisSayisi * 0.05;
                }
                return tabanMaas + prim;
            }
        }

        public override void PersonelBilgi()
        {
            Console.WriteLine(isim + " " + soyIsim + " " + maas);
        }
    }
}
