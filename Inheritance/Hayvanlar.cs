using System;

namespace Inheritance
{

    public class Hayvanlar:Canlilar
    {

        protected void Adaptasyon()
        {

            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
    }

    public class Surungenler:Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
        }

        public void SurunerekHareketEderler(){

            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Solunum();
            base.Bosaltim();
            base.Beslenme();
        }

        public void Ucmak(){

            Console.WriteLine("Kuslar ucar."); 
        }
    }

}