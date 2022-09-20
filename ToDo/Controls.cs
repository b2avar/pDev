using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo
{
    public static class Controls
    {
        static string _baslik, _icerik, _atananKisi, _buyukluk;

        //(1) Board Listelemek
        public static void ListBoard(int id)
        {
            ToDoLine(id);
            InProgressLine(id);
            DoneLine(id);
        }

        //(2) Board'a Kart Eklemek
        public static void AddCard(int id)
        {
            Console.Write("Başlık Giriniz                                 : ");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                 : ");
            string icerik = Console.ReadLine();
            Console.Write("Kişi Giriniz                                   : ");
            string kisi = Console.ReadLine();
            string buyukluk = GetBuyukluk();
            List.toDoLine.Add(id, new CardList(baslik, icerik, kisi, buyukluk));
        }

        //(3) Board'dan Kart Silmek
        public static void DeleteCard()
        {
            bool control = true;
            while (control)
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.Write("Lütfen kart başlığını yazınız : ");
                string baslik = Console.ReadLine();
                // Başlığa ait Key değerini bulma
                var myKeyToDo = List.toDoLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                var myKeyinProg = List.inProgressLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                var myKeyDone = List.doneLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;

                if (List.toDoLine.Keys.Contains(myKeyToDo))
                {
                    List.toDoLine.Remove(myKeyToDo);
                    control = false;
                }

                if (List.inProgressLine.Keys.Contains(myKeyinProg))
                {
                    List.inProgressLine.Remove(myKeyinProg);
                    control = false;
                }

                if (List.doneLine.Keys.Contains(myKeyDone))
                {
                    List.doneLine.Remove(myKeyDone);
                    control = false;
                }

                else
                {
                    if (control == false)
                    {
                        Console.WriteLine("Silme başarılı.");
                        Console.WriteLine();
                    }

                    else
                    {
                        bool control2 = true;
                        while (control2)
                        {
                            ConsoleUI.TwoFactorSelectionUI();
                            int number = int.Parse(Console.ReadLine());
                            if (number == 1)
                            {
                                control2 = false;
                                control = false;
                            }

                            else if (number == 2)
                            {

                                control = true;
                                control2 = false;
                            }

                            else if (number > 2)
                            {
                                ConsoleUI.NoSelectionFoundUI();
                            }
                        }
                    }
                }
            }
        }

        //(4) Kart Taşı
        public static void MoveCard()
        {
            bool select = true;
            while (select)
            {
                try
                {
                    Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                    Console.Write("Lütfen kart başlığını yazınız : ");
                    string baslik = Console.ReadLine();
                    var myKeyToDo = List.toDoLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                    var myKeyinProg = List.inProgressLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                    var myKeyDone = List.doneLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;

                    if (List.toDoLine.Keys.Contains(myKeyToDo) || List.inProgressLine.Keys.Contains(myKeyinProg) || List.doneLine.Keys.Contains(myKeyDone))
                    {
                        if (List.toDoLine.Keys.Contains(myKeyToDo))
                        {
                            NewCardInformation(List.toDoLine, myKeyToDo);
                            ConsoleUI.CardInfoFoundUI(myKeyToDo, List.toDoLine);
                            Console.WriteLine("Line        : TODO");
                            select = false;
                        }
                        else if (List.inProgressLine.Keys.Contains(myKeyinProg))
                        {
                            NewCardInformation(List.inProgressLine, myKeyinProg);
                            ConsoleUI.CardInfoFoundUI(myKeyinProg, List.inProgressLine);
                            Console.WriteLine("Line        : IN PROGRESS");
                            select = false;
                        }

                        else if (List.doneLine.Keys.Contains(myKeyDone))
                        {
                            NewCardInformation(List.doneLine, myKeyDone);
                            ConsoleUI.CardInfoFoundUI(myKeyDone, List.doneLine);
                            Console.WriteLine("Line        : DONE");
                            select = false;
                        }

                        Console.WriteLine();
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz : ");
                        string secim = Console.ReadLine();

                        if (secim == "1" || secim == "2" || secim == "3")
                        {
                            if (secim == "1")
                            {

                                if (List.toDoLine.Keys.Contains(myKeyToDo))
                                {

                                    List.toDoLine.Add(myKeyToDo, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.inProgressLine.Remove(myKeyinProg);
                                    List.doneLine.Remove(myKeyDone);
                                }
                                else if (List.inProgressLine.Keys.Contains(myKeyinProg))
                                {

                                    List.toDoLine.Add(myKeyinProg, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.inProgressLine.Remove(myKeyinProg);
                                    List.doneLine.Remove(myKeyDone);
                                }

                                else if (List.doneLine.Keys.Contains(myKeyDone))
                                {

                                    List.toDoLine.Add(myKeyDone, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.inProgressLine.Remove(myKeyinProg);
                                    List.doneLine.Remove(myKeyDone);

                                }
                                select = false;
                            }

                            else if (secim == "2")
                            {
                                if (List.toDoLine.Keys.Contains(myKeyToDo))
                                {
                                    List.inProgressLine.Add(myKeyToDo, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.doneLine.Remove(myKeyDone);
                                }
                                else if (List.inProgressLine.Keys.Contains(myKeyinProg))
                                {
                                    List.inProgressLine.Add(myKeyinProg, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.doneLine.Remove(myKeyDone);
                                }

                                else if (List.doneLine.Keys.Contains(myKeyDone))
                                {
                                    List.inProgressLine.Add(myKeyDone, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.doneLine.Remove(myKeyDone);
                                }

                                select = false;
                            }

                            else if (secim == "3")
                            {
                                if (List.toDoLine.Keys.Contains(myKeyToDo))
                                {

                                    List.doneLine.Add(myKeyToDo, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.inProgressLine.Remove(myKeyinProg);
                                }
                                else if (List.inProgressLine.Keys.Contains(myKeyinProg))
                                {

                                    List.doneLine.Add(myKeyinProg, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.inProgressLine.Remove(myKeyinProg);
                                }

                                else if (List.doneLine.Keys.Contains(myKeyDone))
                                {

                                    List.doneLine.Add(myKeyDone, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
                                    List.toDoLine.Remove(myKeyToDo);
                                    List.inProgressLine.Remove(myKeyinProg);
                                }
                                select = false;
                            }
                        }

                        else
                        {
                            ConsoleUI.NoSelectionFoundUI();
                        }

                        Console.WriteLine("İşlem başarılı.");

                    }

                    else
                    {
                        bool b = true;
                        while (b)
                        {
                            try
                            {
                                ConsoleUI.TwoFactorSelectionUI();
                                string s = Console.ReadLine();

                                if (s == "1")
                                {
                                    Console.WriteLine("İşlem sonlandırıldı.");
                                    b = false;
                                    select = false;
                                }

                                else if (s == "2")
                                {
                                    b = false;
                                }
                            }
                            catch (System.Exception)
                            {
                                ConsoleUI.NoSelectionFoundUI();
                                Console.WriteLine();
                            }
                        }
                    }
                }
                catch (System.Exception)
                {
                    ConsoleUI.TwoFactorSelectionUI();
                }
            }
        }

        //(05) Kart Güncelle

        public static void UpdateCard()
        {

            bool select = true;
            do
            {
                try
                {
                    Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.Write("Lütfen kart başlığını yazınız : ");
                    string baslik = Console.ReadLine();
                    var myKeyToDo = List.toDoLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                    var myKeyinProg = List.inProgressLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;
                    var myKeyDone = List.doneLine.FirstOrDefault(CardList => CardList.Value.Baslik == baslik).Key;

                    if (List.toDoLine.Keys.Contains(myKeyToDo))
                        select = UpdateNewCardAdd(List.toDoLine, myKeyToDo);

                    if (List.inProgressLine.Keys.Contains(myKeyinProg))
                        select = UpdateNewCardAdd(List.inProgressLine, myKeyinProg);

                    if (List.doneLine.Keys.Contains(myKeyDone))
                        select = UpdateNewCardAdd(List.doneLine, myKeyDone);
                }
                catch (System.Exception)
                {
                    ConsoleUI.TwoFactorSelectionUI();
                }

            } while (select);
        }


        public static void NewCardInformation(Dictionary<int, CardList> list, int keyValue)
        {
            _baslik = list[keyValue].Baslik;
            _icerik = list[keyValue].Icerik;
            _atananKisi = list[keyValue].AtananKisi;
            _buyukluk = list[keyValue].Buyukluk;
        }
        public static bool UpdateNewCardAdd(Dictionary<int, CardList> list, int keyValue)
        {
            list.Remove(keyValue);
            Console.Write("Başlık Giriniz                                 : ");
            string _baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                 : ");
            string _icerik = Console.ReadLine();
            Console.Write("Kişi Giriniz                                   : ");
            string _atananKisi = Console.ReadLine();
            string _buyukluk = GetBuyukluk();
            list.Add(keyValue, new CardList(_baslik, _icerik, _atananKisi, _buyukluk));
            return false;
        }
        public static void ToDoLine(int id)
        {
            ConsoleUI.ListBoardUI("TODO Line");
            ListSystem(id, List.toDoLine);
            ConsoleUI.ThreeSpace();
        }

        public static void InProgressLine(int id)
        {
            ConsoleUI.ListBoardUI("IN PROGRESS Line");
            ListSystem(id, List.inProgressLine);
            ConsoleUI.ThreeSpace();

        }
        public static void DoneLine(int id)
        {
            ConsoleUI.ListBoardUI("DONE Line");
            ListSystem(id, List.doneLine);
            ConsoleUI.ThreeSpace();
        }
        
        public static void ListSystem(int id, Dictionary<int, CardList> list)
        {
            if (list.Count == 0)
                Console.WriteLine("~ BOŞ ~");
            else
            {
                foreach (var item in list)
                {
                    if (id == item.Key)
                    {
                        Console.WriteLine("Başlık      : {0}", item.Value.Baslik);
                        Console.WriteLine("İçerik      : {0}", item.Value.Icerik);
                        Console.WriteLine("Atanan Kişi : {0}", item.Value.AtananKisi);
                        Console.WriteLine("Büyüklük    : {0}", item.Value.Buyukluk);
                        Console.WriteLine("-");
                    }
                }
            }
        }

        public enum Buyukluk { XS, S, M, L, XL }

        public static string GetBuyukluk()
        {
            try
            {
                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        return Buyukluk.XS.ToString();
                    case 2:
                        return Buyukluk.S.ToString();
                    case 3:
                        return Buyukluk.M.ToString();
                    case 4:
                        return Buyukluk.L.ToString();
                    case 5:
                        return Buyukluk.XL.ToString();
                    default:
                        ConsoleUI.NoSelectionFoundUI();
                        Console.WriteLine();
                        return GetBuyukluk();
                }
            }
            catch (System.Exception)
            {
                ConsoleUI.NoSelectionFoundUI();
                Console.WriteLine();
                return GetBuyukluk();
            }
        }
    }
}