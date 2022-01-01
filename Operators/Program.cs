using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignments
            int x = 3;
            int y = 3;

            Console.WriteLine($"X :{x} , y :{y}");
            Console.ReadKey();

            
            y += 2; // or y = y + 2;
            Console.WriteLine($"Addition Y: {y}");
            Console.ReadKey();


            y /= 1; // or y = y / 1;
            Console.WriteLine($"Dividend Y: {y}");
            Console.ReadKey();

            x *= 2; // or x = x * 2;
            Console.WriteLine($"Multiplication x: {x}");
            Console.ReadKey();


            // Logical Operators
            // ||, &&, !
            
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");


            //Relational Operators
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool result = a<b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);


            // Arithmetic Operators
            // +, -, *, /, %, ++, --
            int number1 = 10;
            int number2 = 5;

            int result1 = number1 + number2;
            Console.WriteLine($"Addition result1 : {result1}");

            result1 = number1 - number2;
            Console.WriteLine($"Subtraction result1 : {result1}");

            result1 = number1 * number2;
            Console.WriteLine($"Multiplication result1 : {result1}");

            result1 = number1 / number2;
            Console.WriteLine($"Division result1 : {result1}");

            result1 = number1 % number2;
            Console.WriteLine($"Mod result1 : {result1}");
            
            result1 --;
            Console.WriteLine($"Decrement result1 : {result1}");

            result1 ++;
            Console.WriteLine($"Increment result1 : {result1}");



            
            










        }
    }
}
