using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_list
{
    class Program
    {
        public static void Header(string h){

            Console.WriteLine("****** " + h + " ******");
        }

        public static void PrintList(ArrayList list){

            foreach (var item in list)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            // Koleksiyonlar - ArrayList - Birden fazla veri tipi saklanabilir.
            // System.Collections.namespace

            ArrayList list = new ArrayList();

            // .Add(); - Eleman atama
            Header("Add");
            //list.Add("Burak");
            //list.Add("30");
            //list.Add('B');
            //list.Add(true);


            // İndex numaraları ile elemanlara erişilebilir.
            //Console.WriteLine(list[0]);
            PrintList(list);

            
            //.AddRange(); - birden fazla elemanı toplu halde ekleme.
            Header("Add Range");
            string[] colors = {"red","orange","yellow","green","blue","indigoblue","purple"};
            List<int> oddNumbers = new List<int>(){1,13,3,11,5,9,7};
            //list.AddRange(colors);
            list.AddRange(oddNumbers);
            PrintList(list);

            
            // .Sort(); - sıralama - sort aynı veri türleri için sıralama yapar. Listedeki farklı veri türleri için sıralama yapıldığında Compile Time(derleyici zamanı)' da hata vermezken run time da hata verecektir.
            Header("Sort");
            list.Sort();
            PrintList(list);


            // Binary Search - istenen elemanın index numarasını verir. -  liste elemanları öncelikle sıralandıktan sonra Binary Search metodu kullanılabilir.
            Header("Binary Search");
            Console.WriteLine(list.BinarySearch(9));


            //Reverse - aynalama - en baştaki elemanı en sona, en sondaki elemanı en başa alır.
            Header("Reverse");
            list.Reverse();
            PrintList(list);


            //Clear - listeyi temizler.
            Header("Clear");




 


        }
    }
}
