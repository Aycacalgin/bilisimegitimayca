using System;
using System.Collections.Generic;
using System.Text;

namespace yeniprojem
{
    class SepetManager
    {
        public void Ekle(Urun urun)

        {
            Console.WriteLine("Tebrikler.Urun Sepete eklendi:UrunAdi:"+urun.Adi+" UrunAciklamasi:"+urun.Aciklama+" UrunFiyati:"+urun.Fiyati+" TL");
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int StokAdedi)
        {
            
        }
    }
}
