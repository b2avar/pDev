using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Metotları
            
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 ="CSharp";


            // .Length; - Karakter sayısı
            Console.WriteLine(degisken.Length);

            // .ToUpper(); , .ToLower(); - Karakterlerin hepsini büyültür, küçültür.
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // String.Concat() - Aldığı string parametrelerini birleştirir.
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            // .CompareTo(); - iki değişkeni karşılatırır; karşılaştırılan değer eşitse 0, büyükse 1, küçükse -1 döndürür.
            Console.WriteLine(degisken.CompareTo(degisken2));

            // String.Compare(); - iki değişkeni karşılatırır; karşılaştırılan değer eşitse 0, büyükse 1, küçükse -1 döndürür.
            Console.WriteLine(String.Compare(degisken,degisken2, true)); //ignoreCase iki değişkeni karşılaştırırken büyük-küçük harf duyarlılığını kontrol eder.
            Console.WriteLine(String.Compare(degisken,degisken2, false)); // true; duruma duyarsız kal, false; ise duyarsız kalma.

            // .Contains(); - bir değişken içerisinde diğer değişkenin olup olmadığını true-false olarak döndürür.
            Console.WriteLine(degisken.Contains(degisken2));

            // .StartsWith(); - değişkenin başı belirlenen bir string ifade ile bitiyor mu sorusunu true-false olarak kontrol eder.
            Console.WriteLine(degisken.StartsWith("Merhaba!"));
            
            // .EndWith(); - değişkenin sonu belirlenen bir string ifade ile bitiyor mu sorusunu true-false olarak kontrol eder.
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));

            // .IndexOf(); - değişkenin içerisinde string bir ifadenin olup olmadığını sorgular ve o ifade var ise kaçıncı index'ten başladığını döndürür.
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Burak")); // Eğer string ifade yok ise -1 değeri döndürür.
            Console.WriteLine(degisken.LastIndexOf('a')); // .LastIndexOf(); - istenen char karakterinin degişken içerisindeki son index değerini verir.

            // .Insert(); - belirtilen index değerinden başlayarak string ifadeyi ekler.
            Console.WriteLine(degisken.Insert(0, "Merhaba "));

            // .PadLeft(); PadRight; string değişken karakterinin sayısıdan sonra kalan sayı kadar sağ ya da sol tarafa boşluk ya da belirlenen bir char karakteri ekler.
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2.PadLeft(10,'*'));

            // .Remove(); - belirlen indexten silmeye başlar.
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3)); // 5. indexten başlayarak 3 karakter sil.
            Console.WriteLine(degisken.Remove(0,1)); // en baştaki karakteri siler.

            // .Replace(); - string ifadeleri değiştirir.
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            // .Split(); - belirlenen char türüne göre stringi böl ve istenen indexi getir.
            Console.WriteLine(degisken.Split(' ')[1]);

            // .Substring(); - belirlenen index sayısından itibaren getir.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başla 6 karakter getir.






            

            




        }
    }
}
