using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        //Başlık metodu
        static void Header(string h)
        {
            Console.WriteLine("****** " + h + " ******");
        }

        static void PrintList(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == list[list.Count - 1])
                    Console.Write(list[i]);
                else
                    Console.Write(list[i] + ",");
            }
        }

        static void BigNumbers(ArrayList list)
        {

            list.Sort();
            list.Reverse();

            int total = 0;
            int average = 0;
            int n = 3;

            for (int i = 0; i < n; i++)
            {
                if (i == 2){
                    Console.Write(list[i]);
                }

                else{
                    Console.Write(list[i] + ",");
                }

                total += (int)list[i];
            }

            average = total / n;
            Console.WriteLine();
            Console.WriteLine("Büyük sayilarin ortalamasi : " + average);
        }

        

        static void SmallNumbers(ArrayList list)
        {

            list.Sort();
            int total = 0;
            int average = 0;
            int n = 3;

            for (int i = 0; i < n; i++)
            {
                if (i == 2){
                    Console.Write(list[i]);
                }  
                else{
                    Console.Write(list[i] + "," + " ");
                }

                total += (int)list[i];
            }

            average += total / n;
            Console.WriteLine();
            Console.WriteLine("Küçük sayilarin ortalamasi : " + average);

        }

        static int GetNumber(int i)
        {
            try
            {
                Console.WriteLine($"{i + 1}. sayiyi giriniz :");

                int number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    return number;
                    
                }
                return GetNumber(i);

            }
            catch
            {
                return GetNumber(i);
            }

        }

        static void Main(string[] args)
        {
            // Asal sayilar listesi
            ArrayList numbers = new ArrayList();

            // Asal olmayan sayilar listesi
            ArrayList smallNumber = new ArrayList();

            Console.WriteLine("20 Adet pozitif tamsayi giriniz:");
            // For döngüsü ile kullanicidan istenen sayilari aliyoruz.


            int i = 0;
            do
            {
                numbers.Add(GetNumber(i));
                i++;

            } while (i < 20);

            Console.WriteLine();

            Header("Listedeki Sayilar");
            PrintList(numbers);
            Console.WriteLine();
            Header("Büyük Sayilar");
            BigNumbers(numbers);
            Header("Küçük Sayilar");
            SmallNumbers(numbers);
        }
    }
}
