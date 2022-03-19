using System;

namespace ArraysII
{
    class Program
    {
        static void Main(string[] args)
        {
            //7 elemanlı bir sayı dizisi oluşturalım.
            int[] NumberArray = {23,12,86,72,3,11,17};
            
            //NumberArray dizisi elemanlarını ekrana yazdıralım.
            Console.WriteLine("*** Array ***");
            foreach(var number in NumberArray){
                Console.WriteLine(number);
            }

            //Sort
            Console.WriteLine("*** Array Sort ***");
            //NumberArray dizisi elemanlarını küçükten büyüğe sıralar.
            Array.Sort(NumberArray);
            foreach(var number1 in NumberArray){
                Console.WriteLine(number1);
            }

            //Clear
            Console.WriteLine("*** Array Clear ***");
            //NumberArray dizisi elemanlarını kullanarak 2. indexten itibaren elemanları 0'lar.
            Array.Clear(NumberArray, 2, 3);

            foreach(var number2 in NumberArray){
                Console.WriteLine(number2);
            }
            
            //Reverse
            Console.WriteLine("*** Array Reverse ***");
            //NummberArray dizisi elemanların index sırasını tersine çevirir.
            Array.Reverse(NumberArray);
            foreach(var number3 in NumberArray){
                Console.WriteLine(number3);
            }

            //IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            //Belirtilen nesneyi arar ve tek boyutlu bir dizide veya dizide bir öğe aralığındaki ilk oluşum dizinini döndürür.
            Console.WriteLine(Array.IndexOf(NumberArray, 72));

            //Resize
            Console.WriteLine("*** Array Resize ***");
            //Yeniden boyutlandırma
            Array.Resize<int>(ref NumberArray, 9);
            NumberArray[7] = 99;
            NumberArray[8] = 102;

            foreach(var number4 in NumberArray){
                Console.WriteLine(number4);
            }

            



        }
    }
}
