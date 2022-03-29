using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {

        //Asal sayi kontrol metodu
        static int Asal(int sayi)
        {

            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                    return 0;
            }

            if (i == sayi)
                return 1;

            return 0;
        }

        //Liste siralama metodu
        public static void PrintList(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == list[list.Count - 1])
                    Console.Write(list[i]);
                else
                    Console.Write(list[i] + ",");
            }
        }

        //Başlık metodu
        static void Header(string h)
        {
            Console.WriteLine("****** " + h + " ******");
        }
        static void Main(string[] args)
        {
            // Asal sayilar listesi
            ArrayList primeNumbers = new ArrayList();

            // Asal olmayan sayilar listesi
            ArrayList nonPrimeNumbers = new ArrayList();

            // pozitif tamsayi
            int number = 0;

            Console.WriteLine("20 Adet pozitif tamsayi giriniz:");
            // For döngüsü ile kullanicidan istenen sayilari aliyoruz.
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.WriteLine($"{i + 1}. sayiyi giriniz :");
                    number = int.Parse(Console.ReadLine());
                    if (number < 0)
                        throw new Exception();

                    int result = Asal(number);
                    if (result == 0)
                    {
                        //Console.WriteLine($"{number} sayisi asal degildir.");
                        nonPrimeNumbers.Add(number);

                    }
                    else
                    {
                        //Console.WriteLine($"{number} sayisi asaldir.");
                        primeNumbers.Add(number);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen pozitif bir tamsayi giriniz!");
                }
            }

            // Asal olan sayilar listesini büyükten küçüğe siralama
            primeNumbers.Sort(); // Küçükten büyüğe siralama
            primeNumbers.Reverse(); // tersini alma

            nonPrimeNumbers.Sort();
            nonPrimeNumbers.Reverse();

            Console.WriteLine();

            int primeTotal = 0;
            foreach (var item in primeNumbers)
            {
                primeTotal += (int)item;
            }

            int nonPrimeTotal = 0;
            foreach (var item in nonPrimeNumbers)
            {
                nonPrimeTotal += (int)item;
            }

            Header("Prime Numbers");
            PrintList(primeNumbers);
            Console.WriteLine();
            Console.WriteLine($"Asal olan sayilarin eleman sayisi : {primeNumbers.Count} ");
            Console.WriteLine($"Asal sayilarin ortalamasi : {primeTotal / primeNumbers.Count}");

            Console.WriteLine();

            Header("Non-Prime Numbers");
            PrintList(nonPrimeNumbers);
            Console.WriteLine();
            Console.WriteLine($"Asal olan sayilarim eleman sayisi : {nonPrimeNumbers.Count} ");
            Console.WriteLine($"Asal sayilarin ortalamasi : {nonPrimeTotal / nonPrimeNumbers.Count}");
        }
    }
}
