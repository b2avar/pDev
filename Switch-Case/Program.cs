using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // Expression
            switch (month)
            {
                case 1:
                Console.WriteLine("You're in january.");
                break;

                case 2:
                Console.WriteLine("You're in february.");
                break;

                case 3:
                Console.WriteLine("You're in march.");
                break;

                case 5:
                Console.WriteLine("you're in may.");
                break;

                default:
                Console.WriteLine("Wrong data entry.");
                break;
            }

            
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("You're in the spring season.");
                break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("You're in the summer season.");
                break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("You're in the autumn season.");
                break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("You're in the winter season.");
                break;
                
                default:
                break;
            }
        }
    }
}
