using System;
using System.Collections.Generic;

namespace ToDo
{
    public static class ConsoleUI
    {

        public static void MainMenu()
        {

            Console.WriteLine("ToDo List Menü");
            Console.WriteLine("*******************************************");

            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Kart Güncelle");
            Console.WriteLine("(6) Çıkış");
            Console.Write("Lütfen yapmak istediğiniz işlem numarasını giriniz : ");
        }

        public static void NoSelectionFoundUI()
        {
            Console.WriteLine();
            Console.WriteLine("Seçim bulunamadı!");
            Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
            Console.WriteLine();
        }

        public static void ListBoardUI(string lineName)
        {
            Console.WriteLine(lineName);
            Console.WriteLine("************************");
            Console.WriteLine();
        }

        public static void TwoFactorSelectionUI()
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için     : (2)");
        }

        public static void CardInfoFoundUI(int key, Dictionary<int, CardList> list)
        {
            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.WriteLine("Başlık      : {0}", list[key].Baslik);
            Console.WriteLine("İçerik      : {0}", list[key].Icerik);
            Console.WriteLine("Atanan Kişi : {0}", list[key].AtananKisi);
            Console.WriteLine("Büyüklük    : {0}", list[key].Buyukluk);
        }

        public static void ThreeSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}