using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write the odd numbers up to the number entered by the user on the screen. 
            Console.Write("Please enter a number :");
            int counter = int.Parse(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);    
            }

            // 1-1000 
            
            int even = 0; 
            int odd = 0;;
            for (int i = 1; i <=1000; i++)
            {
                if (i%2 == 0)
                {
                    even += i;
                }
                else if (i % 2 == 1)
                {
                    odd += i;
                }
            }

            Console.WriteLine($"Sum of even numbers: {even}");
            Console.WriteLine($"Sum of odd numbers: {odd}");

            //break.continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
