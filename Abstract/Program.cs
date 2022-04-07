using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine();

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine();

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine();

            //Abstract
            Console.WriteLine("********** New Focus **********");
            Focus newfocus = new Focus();
            Console.WriteLine(newfocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newfocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newfocus.StandartRengiNe().ToString());

            Console.WriteLine();

            Console.WriteLine("********** New Focus **********");
            Focus newCivic = new Focus();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
        }
    }
}
