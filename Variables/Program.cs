using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byt = 5;               // 1 byte
            sbyte sb = 5;               // 1 byte

            short sh = 5;               // 2 byte
            ushort us = 5;              // 2 byte

            Int16 i16 = 5;              // 2 byte
            int i = 5;                  // 4 byte
            Int32 int32 = 5;            // 4 byte
            Int64 int64 = 5;            // 8 byte 

            uint ui = 5;                // 4 byte

            long l = 5;                 // 8 byte
            ulong ul = 5;               // 8 byte - eksi değer alamayan, artı değer alabilen.

            // reel numbers
            float f = 5.2f;            // 4 byte
            double d = 5;              // 8 byte
            decimal dc = 5m;           // 16 byte

            char ch = 'b';             // 2 byte
            string str = "Burak";      // sınırsız

            bool b1 = true;            // 1 byte
            bool b2 = false;           // 1 byte

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'b';
            object o3 = 3;
            object o4 = 3.5;

            // string expressions
            string str1 = ""; // or "= null;"
            string str2 = string.Empty;
            str2 = "Burak Avar";
            string name = "Burak";
            string surname = "Avar";
            string fullName = name + " " + surname;


            // integer definitions
            int i1 = 3;
            int i2 = 5;
            int iMultiplication = i1 * i2;


            // boolean
            bool bl1 = 10<2; // false
            bool bl2 = 10>2; // true

            // variable transformations
            string s20 = "20";
            int i20 = 20;
            string newValue = s20 + i20.ToString(); // output 2020

            int i21 = i20 + Convert.ToInt32(s20);   // output 40

            int i22 = i20 + int.Parse(s20);

            // datetime
            string dateTime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(dateTime);
            string dateTime2 = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(dateTime2);

            // hour
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            // age calc.
            string dTime = DateTime.Now.ToString("yyyy");
            int dd = int.Parse(dTime);
            // Console.WriteLine("Doğum Yılınız :");
            int bDay = int.Parse(Console.ReadLine());
            int age = dd - bDay;
            // Console.WriteLine("Your age :" + " " + age);











            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
