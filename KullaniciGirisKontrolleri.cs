using System;
using System.Globalization;
namespace Proje_1
{
    public static class KullaniciGirisleri{
        public static string AdSoyadGirilsin(string girilecekstr){
                // İlk harf büyük, diğer harflerin küçük olması için:
                // CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().Trim())
            Console.WriteLine("Lütfen {0} giriniz             :", girilecekstr);
            string girilen = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower().Trim());

            while (girilen == ""){
               Console.WriteLine("{0} girilmedi. Lütfen tekrar deneyin", girilecekstr);
               girilen = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower().Trim());
            }
            return girilen;
            
        }

        public static long NoGirilsin(){
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            long n=0;
            while (n==0)
            {
                if (PozitifTamSayiMi(Console.ReadLine().Trim(),out n) == false) {
                    Console.WriteLine("Girilen değer bir pozitif sayı olmalıdır. Lütfen tekrar deneyin :");
                    n=0;
                }
            }
            return n;
        }

        public static bool PozitifTamSayiMi(string str,out long n)
        {
            if ((long.TryParse(str, out n) == false) || (n<=0)){return false;}
            return true;
        }

        public static int AralıktaTamsayıGirilsin(int KucukTamsayı,int BuyukTamsayı)
        {
            int n = 0;
                while (n<KucukTamsayı || n>BuyukTamsayı){
                    int.TryParse(Console.ReadLine(),out n);
                    if (n!=1 && n!=2) {Console.WriteLine("Lütfen tekrar deneyin:");}
                }
            return n;
            
        }
    }
}