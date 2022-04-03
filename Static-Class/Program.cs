using System;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalisan sayisi :{0}",Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Burak", "Avar", "Edu");
            Console.WriteLine("Çalisan sayisi :{0}",Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Tristan", "Tzara", "Dada");
            Calisan calisan3 = new Calisan("Marcel", "Duchamp", "Dada");
            Calisan calisan4 = new Calisan("Michelangelo", "Caravaggio", "Barok");
            Console.WriteLine("Çalisan sayisi :{0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonucu :{0}",Islemler.Topla(100,200));
            Console.WriteLine("Cikarma islemi sonucu :{0}",Islemler.Cikar(200,100));
        }
    }

    class Calisan{

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Ad;
        private string Soyad;
        private string Departman;

        static Calisan(){

            calisanSayisi = 0;
        }

        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler{

        public static long Topla(int sayi1, int sayi2){

            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2){

            return sayi1 - sayi2;
        }
    }
}
