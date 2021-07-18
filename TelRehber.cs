using System;
using System.Collections.Generic;

namespace Proje_1
{
    class TelRehberi{
        public List<Kisi> TelRehber = new List<Kisi>();
        public void KisiyiRehbereKaydet(Kisi yenikisi,bool aciklamayap){
            // Kisi yenikisi = new Kisi(ad,soyad,no);
            TelRehber.Add(yenikisi);
            if (aciklamayap){
                Console.WriteLine("{0} {1} rehbere eklendi. Ana menüye dönmek için ENTER 'a basın:",yenikisi.Ad,yenikisi.Soyad);
                Console.ReadLine();
            }
        }
        public void GüncelleyadaSil(string islemKodu){
            string str1 = "";
            string str2 = "";

            if(islemKodu=="sil"){
                str1="silmek";
                str2="Silmeyi";
            }
            else{
                str1="güncellemek";
                str2="Güncellemeyi";
            }
            
            Kisi GuncellenecekKisi = null;
            Console.WriteLine("Lütfen numarasını {0} istediğiniz kişinin adını ya da soyadını giriniz:",str1);
            string aranacak = KullaniciGirisleri.AdSoyadGirilsin("İsim veya Soyisim");

            foreach (var item in TelRehber)
            {
                if (item.Ad == aranacak || item.Soyad == aranacak){
                    GuncellenecekKisi = item;
                }
            }

            if (GuncellenecekKisi==null){
                // Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:
                Console.WriteLine("Aradığınız krititerlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* {0} sonlandırmak için    : (1)",str2);
                Console.WriteLine("* Yeniden denemek için         : (2)");
                int n = KullaniciGirisleri.AralıktaTamsayıGirilsin(1,2);

                if (n==2){GüncelleyadaSil(islemKodu);}
            }
            else{
                if(islemKodu=="sil"){
                    string yesorno="";
                    
                    while (yesorno !="y" && yesorno !="n")
                    {
                        Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",GuncellenecekKisi.Ad,GuncellenecekKisi.Soyad);
                        yesorno=Console.ReadLine();
                    }
                    if (yesorno =="y"){
                        Console.WriteLine("{0} {1} rehberden silindi. Ana menüye dönmek için ENTER 'a basın:",GuncellenecekKisi.Ad,GuncellenecekKisi.Soyad);
                        TelRehber.Remove(GuncellenecekKisi);
                        Console.ReadLine();
                    }
                        
                }
                else{
                    // Rehberde uygun veri bulunursa güncelleme işlemi gerçekleştirilir.
                    GuncellenecekKisi.No = KullaniciGirisleri.NoGirilsin();
                    Console.WriteLine("{0} {1} kişisinin numarası {2} olarak güncellendi. Ana menüye dönmek için ENTER 'a basın:",GuncellenecekKisi.Ad,GuncellenecekKisi.Soyad,GuncellenecekKisi.No);
                    Console.ReadLine();
                }
            }
        // Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.
        }
        public void Listele(){
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            int listelenensayisi=0;
            foreach (Kisi item in TelRehber)
            {
                item.KisiyiKonsolaYazdir();
                listelenensayisi ++;
            }
            Console.WriteLine("{0} kişi listelendi.",listelenensayisi);
            Console.WriteLine("Rehber listelendi. Ana menüye dönmek için ENTER 'a basın:");
            Console.ReadLine();
        }

        public void AramaYap(){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int n = KullaniciGirisleri.AralıktaTamsayıGirilsin(1,2) ;
            int bulunansay=0;

            if (n==1){
                string aranacak = KullaniciGirisleri.AdSoyadGirilsin("İsim veya Soyisim");
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in TelRehber)
                {
                    if (item.Ad == aranacak || item.Soyad == aranacak){
                        item.KisiyiKonsolaYazdir();
                        bulunansay ++;
                    }
                }
            }
            else if (n==2){
                long aranacak = KullaniciGirisleri.NoGirilsin();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in TelRehber)
                {
                    if (item.No == aranacak){
                        item.KisiyiKonsolaYazdir();
                        bulunansay ++;
                    }
                }
            }
            Console.WriteLine("{0} adet sonuç bulundu.",bulunansay);
            Console.WriteLine("Arama sonuçları listelendi. Ana menüye dönmek için ENTER 'a basın:");
            Console.ReadLine();
        }

    }
}