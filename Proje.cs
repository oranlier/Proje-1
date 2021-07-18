using System;

namespace Proje_1
{

    class Proje
    {
        static void Main(string[] args)
        {
            TelRehberi Rehber = new();
            //varsayılan rehber elemanlarının atanması:
            Rehber.KisiyiRehbereKaydet(new Kisi("Adbir","Soyadbir",1111111111),false);
            Rehber.KisiyiRehbereKaydet(new Kisi("Adiki","Soyadiki",2222222222),false);
            Rehber.KisiyiRehbereKaydet(new Kisi("Adüç","Soyadüç",3333333333),false);
            Rehber.KisiyiRehbereKaydet(new Kisi("Addört","Soyaddört",4444444444),false);
            Rehber.KisiyiRehbereKaydet(new Kisi("Adbeş","Soyadbeş",5555555555),false);

            
            bool cikma = true;
            while (cikma)
            {
            //Ana menunun konsola yazdırılması:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("Çıkmak için ENTER 'a basın:");
            int i = 0;
                if (!int.TryParse(Console.ReadLine(),out i)){
                    Console.WriteLine("İşlem sonlandırıldı.");
                    cikma = false;
                }
            
                if (i==1){
                    string ad = KullaniciGirisleri.AdSoyadGirilsin("İsim");
                    string soyad = KullaniciGirisleri.AdSoyadGirilsin("Soyisim");
                    long no = KullaniciGirisleri.NoGirilsin();
                    Rehber.KisiyiRehbereKaydet(new Kisi(ad,soyad,no),true);
                    cikma = true;  
                }
                else if(i==2){
                    Rehber.GüncelleyadaSil("sil");
                    cikma = true;
                }
                else if(i==3){
                    Rehber.GüncelleyadaSil("guncelle");
                    cikma = true;
                }
                else if(i==4){
                    Rehber.Listele();
                    cikma = true; 
                }
                else if(i==5){
                    Rehber.AramaYap();
                    cikma = true; 
                }
                else{
                    Console.WriteLine("İşlem sonlandırıldı.");
                    cikma = false;
                }
            } 
        }
}


}
