using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class alan hesabı :{0}",dikdortgen.AlanHesapla());

            Console.WriteLine();

            //DikdortgenStruct dikdortgenStruct; // bu kullanım classlar ile yapılamaz.
            //dikdortgenStruct.KisaKenar = 3;
            //dikdortgenStruct.UzunKenar = 4;
            DikdortgenStruct dikdortgenStruct = new DikdortgenStruct(3,4);
            Console.WriteLine("Struct alan hesabı :{0}",dikdortgenStruct.AlanHesapla());

        }
    }

    //16byte >= data, class
    class Dikdortgen{

        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen(){}

        public long AlanHesapla(){

            return this.KisaKenar * this.UzunKenar;
        }
    }

    //16byte<= data, Struct
    struct DikdortgenStruct{

        public int KisaKenar;
        public int UzunKenar;

        public DikdortgenStruct(int kisaKenar, int uzunKenar)// Default constructor oluşturulmasına izin vermiyor ancak bu şekilde izin veriyor.
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla(){

            return this.KisaKenar * this.UzunKenar;
        }
    }
}
