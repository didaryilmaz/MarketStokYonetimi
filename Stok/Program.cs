using System;
using System.Collections.Generic;
using System.Linq;

namespace Stok
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IUrun> urunler = new List<IUrun>
            {
                new Urun (1, "Bulgur", 40, 50, false, false, false),
                new Urun (2, "Kagit Havlu", 120, 60, false, false, false),
                new Urun (3, "Yumurta" , 150 ,30, false, true, false),
                new Urun (4, "Sise Sut", 30, 80, false, true, false),
                new Urun (5, "Yogurt", 100, 25, false, false, true),
                new Urun (6, "Bardak", 35, 40, true, false, false)
            };

            Console.WriteLine("Tüm ürünler:");
            foreach (var urun in urunler.Select(p => $"{p.UrunAdi} - Stok: {p.UrunStokAdeti}"))
            {
                Console.WriteLine(urun);
            }

            Console.WriteLine("Bozuk Ürünler:");
            foreach (var urun in urunler.Where(p => p.BozukMu).Select(p => p.UrunAdi))
            {
                Console.WriteLine(urun);
            }

            Console.WriteLine("Kırık Ürünler:");
            foreach (var urun in urunler.Where(p => p.KırıkMı).Select(p => p.UrunAdi))
            {
                Console.WriteLine(urun);
            }

            Console.WriteLine("Zamanı Geçmiş Ürünler:");
            foreach (var urun in urunler.Where(p => p.ZamanıGecmisMi).Select(p => p.UrunAdi))
            {
                Console.WriteLine(urun);
            }
        }

        static List<Urun> GetUrunler(List<Urun> urunler)
        {
            return urunler.Where(u => u.UrunFiyati > 5000).ToList();
        }
    }
    interface IUrun
    {
        int UrunId { get; set; }
        string UrunAdi { get; set; }
        decimal UrunFiyati { get; set; }
        int UrunStokAdeti { get; set; }

        bool KırıkMı { get; }
        bool BozukMu { get; }
        bool ZamanıGecmisMi { get; }


    }
    class Urun : IUrun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int UrunStokAdeti { get; set; }

        public bool KırıkMı { get; }
        public bool BozukMu { get; }
        public bool ZamanıGecmisMi { get; }

        public Urun(int urunId, string urunAdi, decimal urunFiyati, int urunStokAdeti, bool kirikMi, bool bozukMu, bool zamaniGecmisMi)
        {
            UrunId = urunId;
            UrunAdi = urunAdi;
            UrunFiyati = urunFiyati;
            UrunStokAdeti = urunStokAdeti;
            KırıkMı = kirikMi;
            BozukMu = bozukMu;
            ZamanıGecmisMi = zamaniGecmisMi;
        }
    }
}
