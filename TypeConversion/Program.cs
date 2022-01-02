using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Convertion (Bilinçsiz Dönüşüm)

            byte b = 5;
            sbyte sb = 10;
            short sh = 15;

            int i = b + sb + sh;
            Console.WriteLine("i :" + i);

            long h = i;
            Console.WriteLine("h :" + h);

            float f = h;
            Console.WriteLine("f :" + f);

            string s = "Burak";
            char c = 'A';
            object o = s + c + f;
            Console.WriteLine("o :" + o);



            // Explicit Convertion (Bilinçli Dönüşüm)

            int i1 = 4;
            byte b1 = (byte)i1;
            Console.WriteLine("b1 :" + b1);

            int i2 = 4;
            byte b2= (byte)i2;
            Console.WriteLine("b2 :" + b2);

            float ff = 10.3f;
            byte b3 = (byte)ff;
            Console.WriteLine("b3 :" + b3);


            // ToString Method

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy :" + yy);
            int xxx = int.Parse(yy);
            int zz = xxx * 2;
            Console.WriteLine("zz :" + zz);

            string ss = 12.5f.ToString();
            Console.WriteLine("ss :" + ss);


            // System.Convert Method

            string s1 = "10", s2="20";
            int number1, number2;
            int total;

            number1 = Convert.ToInt32(s1);
            number2 = Convert.ToInt32(s2);
            total = number1 + number2;

            Console.WriteLine("Total :" + total);

            string time = "03.01.2020";
            DateTime dt = Convert.ToDateTime(time);
            Console.WriteLine("dt :" + dt);

            // Parse Method
            ParseMethod();

        }

        public static void ParseMethod(){

            string sentence1 ="10";
            string sentence2 = "10,25";
            int n1;
            double d1;

            n1 = Int32.Parse(sentence1);
            d1 = Double.Parse(sentence2);

            Console.WriteLine("n1 :" + n1);
            Console.WriteLine("d1 :" + d1);

            double dd = 10.25;
            double dddd = dd + d1;
            Console.WriteLine("dddd :" + dddd);

        }
    }
}
