using System;

namespace Classes
{
    class Program
    {
        public static void Header(){

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

            Calisan calisan1 = new Calisan();
            calisan1.Adi = "Burak";
            calisan1.Soyadi = "Avar";
            calisan1.No = 1234;
            calisan1.Departman = "Eğitim Teknolojileri";
            calisan1.CalisanBilgileri();
        
            Header();

            Calisan calisan2 = new Calisan();
            calisan2.Adi = "Wally";
            calisan2.Soyadi = "Pfister";
            calisan2.No = 5678;
            calisan2.Departman = "Cinematography";
            calisan2.CalisanBilgileri();


        }

        class Calisan {

            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int No { get; set; }
            public string Departman { get; set; }
            
            public void CalisanBilgileri(){

                Console.WriteLine("Calisanın Adi: {0}",Adi);
                Console.WriteLine("Calisanın Soyadi: {0}",Soyadi);
                Console.WriteLine("Calisanın No: {0}",No);
                Console.WriteLine("Calisanın Departman: {0}",Departman);

            }
        }
    }
}
