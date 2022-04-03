using System;

namespace Encapsulation_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Burak";
            ogrenci1.Soyad = "Avar";
            ogrenci1.OgrenciNo = 1234;
            ogrenci1.Sinif = 1;
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine();

            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine();

            Ogrenci ogrenci2 = new Ogrenci("Burakk","Avarr",12345,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

            Console.WriteLine();

            ogrenci2.SinifAtlat();
            ogrenci2.SinifAtlat();
            ogrenci2.OgrenciBilgileriniGetir();
            

        }
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public Ogrenci(){}

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public string Ad 
        { 
            get { return ad;} 
            set { ad = value; }
        }

        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set 
            {
                if(value < 1){

                    Console.WriteLine("Sinif en az 1 olabilir!");
                    sinif = 1;
                }
                else{

                    sinif = value;
                }
            } 
        }

        public void OgrenciBilgileriniGetir(){

            Console.WriteLine("********** Ogrenci Bilgileri **********");
            Console.WriteLine("Ogrenci Adi      :{0}",Ad);
            Console.WriteLine("Ogrenci Soyadi   :{0}",Soyad);
            Console.WriteLine("Ogrenci Numarasi :{0}",OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi   :{0}",Sinif);
        }

        public void SinifAtlat(){

            this.Sinif += 1;
        }

        public void SinifDusur(){

            this.Sinif -= 1;
        }
        
    }
}
