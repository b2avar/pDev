using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] colors = new string[5];

            string[] animals = { "cat, dog, bird, monkey" };

            int[] array;
            array = new int[5];

            //Assigning and accessing arrays
            colors[0] = "blue";
            Console.WriteLine(animals[0]);
            array[3] = 10;

            Console.WriteLine(animals[0]);
            Console.WriteLine(colors[0]);

            //Using arrays with the loops

            Console.WriteLine("Please enter the number of elements of the array");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayOfNumber = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Please enter a {0}. number", i + 1);
                arrayOfNumber[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;

            foreach (var number in arrayOfNumber)
            {
                total += number;
            }

            Console.WriteLine("Average :" + total/arrayLength);
        }
    }
}
