using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                              Canlılar
            //                                 |
            //             Bitkiler                          Hayvanlar
            //        |                |                |                 |
            //     Tohumlu         Tohumsuz        Sürüngenler          Kuşlar


            TohumluBitkiler tb01 = new TohumluBitkiler();
            tb01.TohumlaCogalma();

            Console.WriteLine("********************************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();

        }
    }
}

