using System;

namespace Classes_Constructor
{
    class Program
    {
        public static void Header()
        {

            Console.WriteLine("**************************");
        }
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
            //      {
            //       // Metot Komutları
            //      }
            // }

            // Erişim Belirleyiciler
            //   * Public - programın her yerinden erişilebilir.
            //   * Private - sadece tanımlandığı sınıf içerisinden erişilebilir.
            //   * Internal - sadece bulunduğu proje içerisinden erişilebilen propert ve metotlara denir.
            //   * Protected - sadece tanımlandığı sınıfta veya o sınıftan kalıtım(miras) alan diğer sınıflarda kullanılabilir.

            Calisan calisan1 = new Calisan("Burak", "Avar", 1234, "Eğitim Teknolojileri");
            calisan1.CalisanBilgileri();

            Header();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Wally";
            calisan2.Soyad = "Pfister";
            calisan2.No = 5678;
            calisan2.Departman = "Cinematography";
            calisan2.CalisanBilgileri();

            Header();
            
            Calisan calisan3 = new Calisan("Burak", "Avar");
            calisan3.CalisanBilgileri();


        }

        class Calisan
        {

            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int No { get; set; }
            public string Departman { get; set; }

            public Calisan(string ad, string soyad, int no, string departman){

                Ad = ad;
                Soyad = soyad;
                No = no;
                Departman = departman;

            }

            public Calisan(string ad, string soyad)
            {
                Ad = ad;
                Soyad = soyad;
            }

            public Calisan(){}

            public void CalisanBilgileri()
            {

                Console.WriteLine("Calisanın Adi: {0}", Ad);
                Console.WriteLine("Calisanın Soyadi: {0}", Soyad);
                Console.WriteLine("Calisanın No: {0}", No);
                Console.WriteLine("Calisanın Departman: {0}", Departman);

            }
        }
    }
}
