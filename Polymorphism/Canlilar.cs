using System;

namespace Polymorphism
{

    // public sealed class Canlilar - sealed anahtaı kullanilarak kalitim vermesi engellenir.
    public class Canlilar
    {

        protected void Beslenme(){

            Console.WriteLine("Canlilar beslenir.");
        }

        protected void Solunum(){

            Console.WriteLine("Canlilar solunum yapar.");
        }

        protected void Bosaltim(){

            Console.WriteLine("Canlilar bosaltim yaparlar.");


        }

        public virtual void UyaranlaraTepki(){

            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }
    }

}