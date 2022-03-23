using System;

namespace Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int Outsayi;

           //.TryParse boolean şeklinde sonuc verir.
           bool sonuc = int.TryParse(sayi, out Outsayi); //sayının int'e çevrildiğini kontrol et ve çevrilen sayıyı bana Outsayi şeklinde geri dön.

           if(sonuc){
               System.Console.WriteLine("Başarılı!");
               System.Console.WriteLine(Outsayi);

           }

           else{
               System.Console.WriteLine("Başarısız!");

           }

           Metot mt = new Metot();

           mt.Topla(4,5, out int toplamSonuc);
           System.Console.WriteLine(toplamSonuc);
           

           // Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            mt.EkranaYazdir(Convert.ToString(ifade));
            mt.EkranaYazdir(ifade);
            mt.EkranaYazdir("Burak ", "Avar");

            //Metot imzası
            //metotAdi + parametre sayisi + parametre


        }
    }

    public class Metot{

        public void Topla(int a, int b, out int toplam){

            toplam = a + b;
        }

        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri){
            System.Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2){
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
