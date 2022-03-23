using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi method_adi(parametreListesi/arguman)
            //{
            ///komutlar
            //return;
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a,b);
            System.Console.WriteLine(sonuc);

            Metotlar mt = new Metotlar();

            mt.EkranaYazdir(Convert.ToString(sonuc));

            System.Console.WriteLine();
            

            int sonuc2 = mt.ArttırveTopla(ref a, ref b);
            mt.EkranaYazdir(Convert.ToString(a+b));
            mt.EkranaYazdir(Convert.ToString(sonuc2));

        }

        public static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }

    public class Metotlar{
        
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }

        public int ArttırveTopla(ref int deger1, ref int deger2){

            deger1++;
            deger2++;

            return (deger1 + deger2);
        }
    }
}
