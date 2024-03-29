﻿using System;

namespace AlgorithmsQuestions
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Kullanıcıdan n sayısı kadar girilmesi istenen tamsayılardan çift olan tamsayıların ekrana yazdırılması.
            Console.WriteLine("Bir pozitif sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            n.CiftSayilar();

            Console.WriteLine();
            Console.WriteLine("Devam etmek için enter'a basiniz!");
            Console.ReadKey();

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("Pozitif iki tamsayi giriniz!");
            Console.WriteLine("Birinci pozitif tamsayiyi giriniz: ");
            int nn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci pozitif tamsayiyi giriniz: ");
            int mm = Convert.ToInt32(Console.ReadLine());
            EsityadaTamBolunenSayilar(nn,mm);

            Console.WriteLine();
            Console.WriteLine("Devam etmek için enter'a basiniz!");
            Console.ReadKey();
            
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Bir pozitif sayi giriniz: ");
            int nnn = Convert.ToInt32(Console.ReadLine());
            KelimeleriSirala(nnn);

            Console.WriteLine();
            Console.WriteLine("Devam etmek için enter'a basiniz!");
            Console.ReadKey();

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("Bir cümle yazınız: ");
            string cumle = Convert.ToString(Console.ReadLine());
            CumledekiToplamKelimeveHarf(cumle);

   
        }
        public static void EsityadaTamBolunenSayilar(int birinciSayi, int ikinciSayi){

            int[] girilenSayilarDizisi = new int[birinciSayi];
            for (int i = 0; i < birinciSayi; i++)
            {
                Console.WriteLine($"{i+1}. sayiyi girin :");
                girilenSayilarDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write($"{ikinciSayi} sayisina eşit ya da tam bölünen sayilar :");

            foreach (var sayilar in girilenSayilarDizisi)
            {
                if(((sayilar % ikinciSayi) == 0 ) || sayilar == ikinciSayi ){
                    
                    Console.Write(sayilar + ",");
                }
            }

        }

        public static void KelimeleriSirala(int n){

            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}. kelimeyi girin :");
                kelimeler[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("Girilen kelimelerin sondan başa dizilimi :");
            
            for(int j = n-1; j >=0; --j){

                if(j==0){
                    Console.Write(kelimeler[j]);
                }
                else{
                    Console.Write(kelimeler[j] + ", ");
                }
            }
        }

        public static void CumledekiToplamKelimeveHarf(string param){

            char[] ch = param.ToCharArray();
            
            int toplamHarf = 0;
            string[] toplamKelime = param.Split(' ');

            foreach (var c in ch)
            {
                if(char.IsLetterOrDigit(c)){

                    toplamHarf++;
                }
            }

            Console.WriteLine("Cümledeki toplam harf :" + toplamHarf);
            Console.WriteLine("Cümledeki toplam kelime :" + toplamKelime.Length);

        }
    }
    public static class MyExtension{
        public static void CiftSayilar(this int girilenSayi){

            int[] girilenSayilarDizisi = new int[girilenSayi];
            for (int i = 0; i < girilenSayi; i++)
            {
                Console.WriteLine($"{i+1}. sayiyi girin :");
                girilenSayilarDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Çift sayilar :");

            foreach (var sayilar in girilenSayilarDizisi)
            {
                if((sayilar % 2) == 0){
                    
                    Console.Write(sayilar + ",");
                }
            }
        }
    }
}
