using System;

namespace MarketStokYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            TamZamanliPersonel personel1 = new TamZamanliPersonel { Isim = "didar", SoyIsim = "yilmaz", SatisSayisi = 100, TabanMaas = 1000 };
            TamZamanliPersonel personel2 = new TamZamanliPersonel { Isim = "melike", SoyIsim = "yilmaz", SatisSayisi = 200, TabanMaas = 1000 };
            TamZamanliPersonel personel3 = new TamZamanliPersonel { Isim = "sevda", SoyIsim = "yilmaz", SatisSayisi = 300, TabanMaas = 1000 };


            YariZamanliPersonel personel4 = new YariZamanliPersonel { Isim = "ahmet", SoyIsim = "yilmaz", SatisSayisi = 400, CalistigiSaat = 8, SaatUcreti = 200 };
            YariZamanliPersonel personel5 = new YariZamanliPersonel { Isim = "mehmet", SoyIsim = "yilmaz", SatisSayisi = 500, CalistigiSaat = 8, SaatUcreti = 200 };
            YariZamanliPersonel personel6 = new YariZamanliPersonel { Isim = "ali", SoyIsim = "yilmaz", SatisSayisi = 600, CalistigiSaat = 8, SaatUcreti = 200 };


            PersonelIslemleri.PersonelEkle(personel1);
            PersonelIslemleri.PersonelEkle(personel2);
            PersonelIslemleri.PersonelEkle(personel3);
            PersonelIslemleri.PersonelEkle(personel4);

            PersonelIslemleri.PersonelListele();
        }
    }
}
