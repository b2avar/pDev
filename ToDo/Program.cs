using System;
using System.Collections.Generic;

namespace ToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool conTinue = true;

            do
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

            } while (conTinue);
        }
        static bool AnotherAction()
        {
            bool control = true;
            do
            {
                try
                {
                    Console.Write("Başka bir işlem yapmak istiyor musunuz? (y/n) : ");
                    char answer = char.Parse(Console.ReadLine());

                    if (answer == 'y')
                    {
                        Console.WriteLine("İşlem Tamamladı.");
                        control = false;
                        return true;
                    }
                    else if (answer == 'n')
                    {
                        Console.WriteLine("İşlem Tamamladı.");
                        control = false;
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    ConsoleUI.NoSelectionFoundUI();

                }
            } while (control);

            ConsoleUI.NoSelectionFoundUI();
            return true;
        }
        static int GetChoose()
        {
            try
            {
                ConsoleUI.MainMenu();
                sbyte chooseOption = Convert.ToSByte(Console.ReadLine());

                if (chooseOption > 0 && chooseOption < 7)
                {
                    return chooseOption;
                }
                else
                {
                    ConsoleUI.NoSelectionFoundUI();
                    return GetChoose();
                }
            }
            catch (System.Exception)
            {
                ConsoleUI.NoSelectionFoundUI();
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