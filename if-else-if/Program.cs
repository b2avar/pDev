using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 5 && time <= 12)
                Console.WriteLine("Good Morning");
            else if (time > 12 && time <= 18)
                Console.WriteLine("Good Afternoon");
            else if (time > 18 && time <= 22)
                Console.WriteLine("Good Evening");
            else if (time > 22 && time <= 4)
                Console.WriteLine("Good Night");

            string result = time <= 18 ? "Have a nice day!" : "Good Evening!";
            result = time >= 5 && time <= 12 ? "Good Morning" : time > 12 && time <= 18 ? "Good Afternoon" : 
            time > 18 && time <= 22 ? "Good Evening" : time > 22 && time <= 4 ? "Good Night" : " ";
            Console.WriteLine(result);
        }
    }
}
