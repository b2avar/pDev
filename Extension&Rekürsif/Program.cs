using System;

namespace Extension_Rekürsif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }

            System.Console.WriteLine(result);

            Islemler instance = new();

            System.Console.WriteLine(instance.Expo(3,4));

            // Extension Metotlar
            string ifade = "Burak Avar";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);

            if(sonuc){

                System.Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            System.Console.WriteLine(ifade.MakeUpperCase());
            System.Console.WriteLine(ifade.MakeLowerrCase());

            int[] dizi = {9, 3, 6, 2, 1, 5, 0};

            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            System.Console.WriteLine(sayi.IsEvenNumber()); 

            System.Console.WriteLine(ifade.GetFirstCharacter());






        }
    }

    public class Islemler{
        

        public int Expo(int sayi, int us){
            if (us<2)
            {
                return sayi;
            }

            return Expo(sayi, us-1) * sayi;
        }

        //Expo(3,4)
        //Expo(3,3) * 3;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 * 3;
        //3 * 3 * 3 * 3;
    }

    public static class Extension{

        public static bool CheckSpaces(this string param){

            return param.Contains(" "); // Contains, string kütüphanesi;
        }

        public static string RemoveWhiteSpaces(this string param){

            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpperCase(this string param){

            return param.ToUpper();
        }

        public static string MakeLowerrCase(this string param){

            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){

            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){

            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param){

            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param){

            return param.Substring(0, 1);
        }







    }



}
