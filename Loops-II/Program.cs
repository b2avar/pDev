using System;

namespace Loops_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // (1...(n)) => μ => printConsole
            Console.WriteLine("Please enter a number :");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            int total = 0;

            while (counter <= number)
            {
                 total += counter;
                 counter++;
            }
            Console.WriteLine(total);

            Console.WriteLine(total/number);

            // (a...z) => printConsole
            char c = 'a';
            while (c < 'z')
            {
                 Console.Write(c + ",");
                 c++;
            }
            
            //Foreach
                string[] cars = new string[]{"BMW", "Toyota", "Ford", "Nissan"};

                Console.WriteLine();
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }




        }
    }
}
