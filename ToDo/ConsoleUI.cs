using System;

namespace ToDo
{
    public static class ConsoleUI
    {

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

        public static void TwoFactorSelection()
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için     : (2)");
        }
    }
}