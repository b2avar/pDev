using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cuma);

            int sicaklik = 28;

            if(sicaklik <= (int)HavaDurumu.Normal){

                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim.");
            }
            else if(sicaklik>=(int)HavaDurumu.Sicak){

                Console.WriteLine("Dısariya cikmak icin cok sicak bir gun");
            }

            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak){

                Console.WriteLine("Hadi disariya cikalim!");
            }
        }
    }

    // Enum

    // Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum lasrdan faydalanırız.

    // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.

    // Ardışık tabik eder.
    // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
    enum Gunler{

        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    // Yukarıda Gunler enum'ını görüyorsunuz. Enum lar default olarak 1'den başlar.
    //Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. Eğer Pazartesinin 1. gün oldugu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi** 

    enum HavaDurumu{

        Soguk = 5,

        Normal = 20,
        Sicak = 25,
        CokSicak = 30

    }
}
