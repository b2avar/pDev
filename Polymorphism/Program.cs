using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvanlar hyn = new Hayvanlar();
            hyn.UyaranlaraTepki();
            
            Kuslar ks = new Kuslar();
            ks.Ucmak();
            ks.UyaranlaraTepki();
        }
    }
}
