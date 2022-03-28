using System;
using System.Collections.Generic;

namespace Dictionary_
{
    class Program
    {
        public static void Header(string h){

            Console.WriteLine("****** " + h + " ******");
        }

        public static void Print(Dictionary<int,string> dc){

            foreach (var item in dc)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //System.Collections.Generic; - Key-Value;
            Dictionary<int,string> users = new Dictionary<int, string>();

            //Add - Key deperi unique olmalıdır.
            Header("Add");
            users.Add(30, "Burak Avar");
            //users.Add(30, "Burak Avar"); // Compile time da hata vermiyor anca aynı key tekrar eklenemez, run time da hata ile karşılaşılır.
            users.Add(67, "Jane Campion");
            users.Add(64, "Hans Zimmer");
            users.Add(61, "Kenneth Branagh");
            Print(users);

            // Dizinin elemanlarına erişme
            Header("Elemanlara Erişim");
            Console.WriteLine(users[30]); // key ile value değerini sorgulama.
            Print(users);

            //.Count;
            Header("Count");
            Console.WriteLine(users.Count);


            //.ContainsKey(); .ContainsValue(); değerelre sahip elemanlar var mı?
            Header("ContainsKey & ContainsValue");
            Console.WriteLine(users.ContainsKey(64));
            Console.WriteLine(users.ContainsValue("Denis Villeneuve"));


            //.Remove(); - Eleman çıkarma işleminde method(fonksiyon) key değerini ister.
            Header("Remove");
            users.Remove(67);
            Print(users);
            Console.WriteLine(users.Keys);
            Console.WriteLine(users.Values);

            //Keys
            Header("Keys");
            foreach (var item in users.Keys)
                Console.WriteLine(item);

            //Values
            Header("Values");
            foreach (var item in users.Values)
                Console.WriteLine(item);






        }
    }
}
