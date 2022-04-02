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

        static int GetNumber(int i)
        {
            try
            {
                Console.WriteLine($"{i + 1}. sayiyi giriniz :");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 ){
                    
                    return number;
                    
                }
                else{

                    Console.WriteLine("Lütfen pozitif bir tamsayi giriniz!");
                    return GetNumber(i);
                }
                
            }

            catch
            {
                Console.WriteLine("Lütfen pozitif bir tamsayi giriniz!");
                return GetNumber(i);
            }

        }

        //Başlık metodu
        static void Header(string h)
        {
            Console.WriteLine("****** " + h + " ******");
        }
        static void Main(string[] args)
        {
            //Sayilar Listesi
            int[] numbers = new int[20];
            
            // Asal sayilar listesi
            ArrayList primeNumbers = new ArrayList();

            // Asal olmayan sayilar listesi
            ArrayList nonPrimeNumbers = new ArrayList();

            Console.WriteLine("20 Adet pozitif tamsayi giriniz:");
            int i = 0;
            do
            {
                numbers[i] = GetNumber(i);
                i++;

            } while (i < 20);

            Console.WriteLine();

            foreach (var item in numbers)
            {
                int result = Asal(item);
                if(result == 0){

                    nonPrimeNumbers.Add(item);
                }
                else{

                    primeNumbers.Add(item);
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
