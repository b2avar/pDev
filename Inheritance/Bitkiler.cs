using System;

namespace Inheritance
{

    public class Bitkiler:Canlilar
    {

         protected void Fotosentez(){

             Console.WriteLine("Bitkiler fotosentez yapar.");
         }   
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.Fotosentez();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
        }

        public void TohumlaCogalma(){

            Console.WriteLine("Tohumlu bitkiler tohumla cogalir");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
        }

        public void SporlaCogalma(){

            Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
        }
    }

}