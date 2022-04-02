using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {

        static void PrintList(ArrayList list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == list[list.Count - 1])
                    Console.Write(list[i]);
                else
                    Console.Write(list[i] + ",");
            }
        }
        static void Header(string h)
        {
            Console.WriteLine("****** " + h + " ******");
        }
        static void Main(string[] args)
        {
            //Sesli harfler dizisi
            char[] vowels = {'a','e','ı','i','o','ö','u','ü'};

            //Sesli harf listesi oluşturma
            ArrayList vowelsList = new ArrayList();

            // Kullanicidan bir cümle isteme
            Console.WriteLine("Lütfen bir cümle giriniz!");
            string sentence = Console.ReadLine();

            // Cümledeki karakterleri bir karakter dizisine kopyalayalım
            char[] charOfSentence = sentence.ToCharArray();

            // For döngüsü ile cümle içerisinde hangi sesli harflerin olduğunu bulma
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < vowels.Length-1; j++)
                {
                    if (charOfSentence[i] == vowels[j])
                    {
                        vowelsList.Add(vowels[j]);
                        break;
                    }
                }
            }

            Header("Sesli Harfler");
            vowelsList.Sort();
            PrintList(vowelsList);
        }
    }
}
