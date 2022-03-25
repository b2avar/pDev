using System;

namespace DateTimeandMathClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarih - Saat

            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime - Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // gün-sayi
            Console.WriteLine(DateTime.Now.ToString("ddd")); // günün ilk 3 harfi
            Console.WriteLine(DateTime.Now.ToString("dddd")); // günün ismi

            Console.WriteLine(DateTime.Now.ToString("MM")); // ay-sayi
            Console.WriteLine(DateTime.Now.ToString("MMM")); // ayın ilk 3 harfi
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // ayın ismi

            Console.WriteLine(DateTime.Now.ToString("yy")); // yıl-sayi
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yılın sayı karşılığı

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-5)); // Mutlak değer
            Console.WriteLine(Math.Sin(45)); // Sinüs karşılığı
            Console.WriteLine(Math.Cos(45)); // Cosinüs karşılığı
            Console.WriteLine(Math.Tan(45)); // Tanjant karşılığı

            Console.WriteLine(Math.Ceiling(22.3)); // Girilen sayıdan büyük en küçük tamsayı
            Console.WriteLine(Math.Round(22.3));   // Hangi tamsayıya daha yakınsa
            Console.WriteLine(Math.Floor(22.7));   // Girilen sayıdan küçük en büyük tamsayı

            Console.WriteLine(Math.Max(2,6)); // iki sayinin max'ini hesaplar.
            Console.WriteLine(Math.Min(2,6)); // iki sayinin min'ini hesaplar.

            Console.WriteLine(Math.Pow(3,4));  // üs alma
            Console.WriteLine(Math.Sqrt(81));  // karekök
            Console.WriteLine(Math.Log(9));    // 9'un e tabanindaki logaritmik karsiligi
            Console.WriteLine(Math.Exp(3));    // e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(5));  // 5 sayisinin 10 tabanında logaritmik karsiligi

        }
    }
}
