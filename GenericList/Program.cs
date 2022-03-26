using System;
using System.Collections.Generic;

namespace GenericList
{
    class Users{

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Users(string name, string surname, int age){

            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    static class MyExtension{

        public static void IntPrintList(this List<int> list){

            list.ForEach(l=> Console.WriteLine(l));
        }

        public static void StrPrintList(this List<string> list){

            list.ForEach(l=> Console.WriteLine(l));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic;
            // T -> object türündedir. Hangi tipten oluşan nesne eklenecek?

            List<int> oddNumbersList = new List<int>();

            oddNumbersList.Add(1);
            oddNumbersList.Add(3);
            oddNumbersList.Add(5);
            oddNumbersList.Add(7);
            oddNumbersList.Add(9);
            oddNumbersList.Add(11);

            List<string> colorsList = new List<string>();

            colorsList.Add("Red");
            colorsList.Add("Orange");
            colorsList.Add("Yellow");
            colorsList.Add("Green");
            colorsList.Add("Blue");
            colorsList.Add("NavyBlue");
            colorsList.Add("Purple");

            // Kaç tane eleman var - .Count;
            Console.WriteLine(oddNumbersList.Count);
            Console.WriteLine(colorsList.Count);

            // Foreach ile elemanlara erişim
            foreach (var oddNumbers in oddNumbersList)
            {
                Console.WriteLine(oddNumbers);
            }

            foreach (var colors in colorsList)
            {
                Console.WriteLine(colors);
            }

            // List.Foreach ile elemanlara erişim - Metot 2 - Lambda ifadesi - "=>" öyle ki;
            oddNumbersList.ForEach(oddNumbers=> Console.WriteLine(oddNumbers));
            colorsList.ForEach(colors=> Console.WriteLine(colors));

            // Listeden eleman çıkarma.
            oddNumbersList.Remove(11);
            oddNumbersList.IntPrintList(); // Extension metot kullanildi.

            colorsList.Remove("NavyBlue"); // Extension metot kullanildi.
            colorsList.StrPrintList();

            // Liste içerisinde arama - .Contains(); - bir ögenin olup olmadığını kontrol eder.
            if(oddNumbersList.Contains(9))
                Console.WriteLine("9 liste içerisinde bulundu.");
            else
                Console.WriteLine("öge bulunamadı.");

            // Eleman ile index'e erişme - .BinarySearch();
            /*Array.BinarySearch() fonksiyonunun kullanılacağı listelerin her bir elemanının eşsiz ve dizinin sıralı olması gerekir. BinarySearch() fonksiyonu (algoritması), özellikle büyük dizi ve listelerde sıralı aramaya göre çok daha hızlıdır.
            dizinin Sort() ile sıralandıktan sonra BinarySearch() fonksiyonu ile dizinin indexine ulaşılır.*/
            colorsList.Sort();
            colorsList.StrPrintList();
            Console.WriteLine(colorsList.BinarySearch("Green"));

            // Diziyi List'e çevirme
            string[] arrayAnimals = new string[]{"cat", "dog", "bird", "monkey"};
            List<string> listAnimals = new List<string>(arrayAnimals);
            listAnimals.StrPrintList();

            // Listeyi nasıl temizleriz - .Clear();
            listAnimals.Clear();
            Console.WriteLine(listAnimals.Count);

            // Liste içerisinde nesne tutmak
            List<Users> usersList = new List<Users>();
            Users burak = new Users("Burak","Avar",30);
            Users khondji = new Users("Darius","Khondji",66);
            Users villeneuve = new Users("Denis","Villeneuve",54);
            Users hopkins = new Users("Anthony","Hopkins",84);

            usersList.Add(burak);
            usersList.Add(khondji);
            usersList.Add(villeneuve);
            usersList.Add(hopkins);

            foreach (Users users in usersList)
            {
                Console.Write(users.Name + " ");
                Console.Write(users.Surname + " ");
                Console.Write(users.Age + " - ");
            }

            // Listeye kullanıcı atama işlemleri başka nasıl yapılabilir.
            List<Users> newList = new List<Users>();
            newList.Add(new Users("Burak","Avar",30));

            foreach (Users users in newList )
            {
                Console.WriteLine(users.Name);
                Console.WriteLine(users.Surname);
                Console.WriteLine(users.Age);
            }

            usersList.Clear();
            newList.Clear();

            Console.WriteLine(usersList.Count);
            Console.WriteLine(newList.Count);

        }
    }
}
