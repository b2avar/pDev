using System;
using System.Collections.Generic;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool conTinue = true;

            while (conTinue)
            {
                switch (GetChoose())
                {
                    case 1:
                        //Board Listele
                        ListBoard();
                        break;
                    case 2:
                        //Kart Ekle
                        AddCard();
                        break;
                    case 3:
                        //Kart Sil
                        Controls.DeleteCard();
                        break;
                    case 4:
                        //Kart Taşı
                        Controls.MoveCard();
                        break;
                    case 5:
                        //Kart Güncelle
                        Controls.UpdateCard();
                        break;
                    case 6:
                        //Çıkış
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        break;
                }

                conTinue = AnotherAction();
            }
        }
        static bool AnotherAction()
        {
            bool control3 = true;
            while (control3)
            {
                try
                {
                    Console.Write("Başka bir işlem yapmak istiyor musunuz? (y/n) : ");
                    char answer = char.Parse(Console.ReadLine());

                    if (answer == 'y')
                    {
                        Console.WriteLine("İşlem Tamamladı.");
                        control3 = false;
                        return true;
                    }
                    else if (answer == 'n')
                    {
                        Console.WriteLine("İşlem Tamamladı.");
                        control3 = false;
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Seçim bulunamadı!");
                    Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Seçim bulunamadı!");
            Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
            Console.WriteLine();
            return true;
        }
        static int GetChoose()
        {
            try
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

                sbyte chooseOption = Convert.ToSByte(Console.ReadLine());



                if (chooseOption > 0 && chooseOption < 7)
                {
                    return chooseOption;
                }
                else
                {
                    Console.WriteLine("Seçim bulunamadı!");
                    Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
                    Console.WriteLine();
                    return GetChoose();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Seçim bulunamadı!");
                Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
                Console.WriteLine();
                return GetChoose();
            }
        }

        static void AddCard()
        {
            bool control = true;

            while (control)
            {
                try
                {
                    Console.Write("Lütfen geçerli bir ID numarası giriniz : ");
                    int id = int.Parse(Console.ReadLine());

                    if (TeamMembers.TeamList().Contains(id))
                    {

                        Controls.AddCard(id);
                        control = false;
                        break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("ID numarası bulunamadı.");
                    Console.WriteLine();
                }
            }
        }

        static void ListBoard()
        {

            bool control = true;

            while (control)
            {
                try
                {
                    Console.Write("Lütfen geçerli bir ID numarası giriniz : ");
                    int id = int.Parse(Console.ReadLine());

                    if (TeamMembers.TeamList().Contains(id))
                    {

                        Controls.ListBoard(id);
                        control = false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("ID numarası bulunamadı.");
                    Console.WriteLine();
                }
            }
        }
    }
}