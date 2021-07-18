using System;

namespace Proje_1
{
    class Kisi{
        private string ad;
        private string soyad;
        private long no;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public long No { get => no; set => no = value; }

        public Kisi(string ad,string soyad,long no)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
        }

        public void KisiyiKonsolaYazdir(){          
            Console.WriteLine("isim: {0}",this.ad);
            Console.WriteLine("Soyisim: {0}",this.Soyad);
            Console.WriteLine("Telefon Numarası: {0}",this.No);
            Console.WriteLine("-");
        }
    }
}