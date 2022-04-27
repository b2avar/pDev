using System;

namespace Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengine().ToString());

            Console.WriteLine();

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengine().ToString());

            Console.WriteLine();

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRengine().ToString());

        }
    }
}
