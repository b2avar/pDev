namespace ToDo
{
    public static class Controls
    {
        static string? _title;
        static string? _content;
        static string? _person;
        static string? _size;

        //(1) List board
        public static void ListBoard(int id)
        {
            ToDoLine(id);
            InProgressLine(id);
            DoneLine(id);
        }

        //(2) Add card to board
        public static void AddCard(int id)
        {
            Console.Write("Enter Title                                 : ");
            string? title = Console.ReadLine();
            Console.Write("Enter Content                               : ");
            string? content = Console.ReadLine();
            Console.Write("Enter Person                                : ");
            string? person = Console.ReadLine();
            string? size = GetSize();
            List.ToDoLine.Add(id, new CardList(title, content, person, size));
        }

        //(3) Delete card from board
        public static void DeleteCard()
        {
            bool control = true;
            while (control)
            {
                ConsoleUı.CardTitle();
                string? title = Console.ReadLine();
                // Finding the Key value of the title
                var myKeyToDo = List.ToDoLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyInPro = List.İnProgressLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyDone = List.DoneLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;

                if (List.ToDoLine.Keys.Contains(myKeyToDo))
                {
                    List.ToDoLine.Remove(myKeyToDo);
                    control = false;
                }

                if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                {
                    List.İnProgressLine.Remove(myKeyInPro);
                    control = false;
                }

                if (List.DoneLine.Keys.Contains(myKeyDone))
                {
                    List.DoneLine.Remove(myKeyDone);
                    control = false;
                }

                else
                {
                    if (control == false)
                    {
                        Console.WriteLine("Deletion successful.");
                        Console.WriteLine();
                    }

                    else
                    {
                        bool control2 = true;
                        while (control2)
                        {
                            ConsoleUı.TwoFactorSelectionUı();
                            int number = int.Parse(Console.ReadLine() ?? string.Empty);
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
                                ConsoleUı.NoSelectionFoundUı();
                            }
                        }
                    }
                }
            }
        }

        //(4) Move card
        public static void MoveCard()
        {
            bool select = true;
            while (select)
            {
                try
                {
                    ConsoleUı.CardTitle();
                    string? title = Console.ReadLine();
                    var myKeyToDo = List.ToDoLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                    var myKeyInPro = List.İnProgressLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                    var myKeyDone = List.DoneLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;

                    if (List.ToDoLine.Keys.Contains(myKeyToDo) || List.İnProgressLine.Keys.Contains(myKeyInPro) || List.DoneLine.Keys.Contains(myKeyDone))
                    {
                        if (List.ToDoLine.Keys.Contains(myKeyToDo))
                        {
                            NewCardInformation(List.ToDoLine, myKeyToDo);
                            ConsoleUı.CardInfoFoundUı(myKeyToDo, List.ToDoLine);
                            Console.WriteLine("Line        : TODO");
                            select = false;
                        }
                        else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                        {
                            NewCardInformation(List.İnProgressLine, myKeyInPro);
                            ConsoleUı.CardInfoFoundUı(myKeyInPro, List.İnProgressLine);
                            Console.WriteLine("Line        : IN PROGRESS");
                            select = false;
                        }

                        else if (List.DoneLine.Keys.Contains(myKeyDone))
                        {
                            NewCardInformation(List.DoneLine, myKeyDone);
                            ConsoleUı.CardInfoFoundUı(myKeyDone, List.DoneLine);
                            Console.WriteLine("Line        : DONE");
                            select = false;
                        }

                        Console.WriteLine();
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        Console.Write("Please select the Line you want to move : ");
                        string? choose = Console.ReadLine();

                        if (choose == "1" || choose == "2" || choose == "3")
                        {
                            if (choose == "1")
                            {

                                if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                {

                                    List.ToDoLine.Add(myKeyToDo, new CardList(_title, _content, _person, _size));
                                    List.İnProgressLine.Remove(myKeyInPro);
                                    List.DoneLine.Remove(myKeyDone);
                                }
                                else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                {

                                    List.ToDoLine.Add(myKeyInPro, new CardList(_title, _content, _person, _size));
                                    List.İnProgressLine.Remove(myKeyInPro);
                                    List.DoneLine.Remove(myKeyDone);
                                }

                                else if (List.DoneLine.Keys.Contains(myKeyDone))
                                {

                                    List.ToDoLine.Add(myKeyDone, new CardList(_title, _content, _person, _size));
                                    List.İnProgressLine.Remove(myKeyInPro);
                                    List.DoneLine.Remove(myKeyDone);

                                }
                                select = false;
                            }

                            else if (choose == "2")
                            {
                                if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                {
                                    List.İnProgressLine.Add(myKeyToDo, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.DoneLine.Remove(myKeyDone);
                                }
                                else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                {
                                    List.İnProgressLine.Add(myKeyInPro, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.DoneLine.Remove(myKeyDone);
                                }

                                else if (List.DoneLine.Keys.Contains(myKeyDone))
                                {
                                    List.İnProgressLine.Add(myKeyDone, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.DoneLine.Remove(myKeyDone);
                                }

                                select = false;
                            }

                            else if (choose == "3")
                            {
                                if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                {

                                    List.DoneLine.Add(myKeyToDo, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.İnProgressLine.Remove(myKeyInPro);
                                }
                                else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                {

                                    List.DoneLine.Add(myKeyInPro, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.İnProgressLine.Remove(myKeyInPro);
                                }

                                else if (List.DoneLine.Keys.Contains(myKeyDone))
                                {

                                    List.DoneLine.Add(myKeyDone, new CardList(_title, _content, _person, _size));
                                    List.ToDoLine.Remove(myKeyToDo);
                                    List.İnProgressLine.Remove(myKeyInPro);
                                }
                                select = false;
                            }
                        }

                        else
                        {
                            ConsoleUı.NoSelectionFoundUı();
                        }

                        Console.WriteLine("Transaction successful.");

                    }

                    else
                    {
                        bool b = true;
                        while (b)
                        {
                            try
                            {
                                ConsoleUı.TwoFactorSelectionUı();
                                string? s = Console.ReadLine();

                                if (s == "1")
                                {
                                    Console.WriteLine("Process terminated.");
                                    b = false;
                                    select = false;
                                }

                                else if (s == "2")
                                {
                                    b = false;
                                }
                            }
                            catch (Exception)
                            {
                                ConsoleUı.NoSelectionFoundUı();
                                Console.WriteLine();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    ConsoleUı.TwoFactorSelectionUı();
                }
            }
        }

        //(05) Update card

        public static void UpdateCard()
        {

            bool select = true;
            do
            {
                try
                {
                    ConsoleUı.CardTitle();
                    string? title = Console.ReadLine();
                    var myKeyToDo = List.ToDoLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                    var myKeyInPro = List.İnProgressLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                    var myKeyDone = List.DoneLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;

                    if (List.ToDoLine.Keys.Contains(myKeyToDo))
                        select = UpdateNewCardAdd(List.ToDoLine, myKeyToDo);

                    if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                        select = UpdateNewCardAdd(List.İnProgressLine, myKeyInPro);

                    if (List.DoneLine.Keys.Contains(myKeyDone))
                        select = UpdateNewCardAdd(List.DoneLine, myKeyDone);
                }
                catch (Exception)
                {
                    ConsoleUı.TwoFactorSelectionUı();
                }

            } while (select);
        }


        private static void NewCardInformation(Dictionary<int, CardList> list, int keyValue)
        {
            _title = list[keyValue].Title;
            _content = list[keyValue].Content;
            _person = list[keyValue].Person;
            _size = list[keyValue].Size;
        }

        private static bool UpdateNewCardAdd(Dictionary<int, CardList> list, int keyValue)
        {
            list.Remove(keyValue);
            Console.Write("Enter Title                                 : ");
            string? title = Console.ReadLine();
            Console.Write("Enter Content                               : ");
            string? content = Console.ReadLine();
            Console.Write("Enter Person                                : ");
            string? person = Console.ReadLine();
            string? size = GetSize();
            list.Add(keyValue, new CardList(title, content, person, size));
            return false;
        }

        private static void ToDoLine(int id)
        {
            ConsoleUı.ListBoardUı("TODO Line");
            ListSystem(id, List.ToDoLine);
            ConsoleUı.ThreeSpace();
        }

        private static void InProgressLine(int id)
        {
            ConsoleUı.ListBoardUı("IN PROGRESS Line");
            ListSystem(id, List.İnProgressLine);
            ConsoleUı.ThreeSpace();

        }

        private static void DoneLine(int id)
        {
            ConsoleUı.ListBoardUı("DONE Line");
            ListSystem(id, List.DoneLine);
            ConsoleUı.ThreeSpace();
        }

        private static void ListSystem(int id, Dictionary<int, CardList> list)
        {
            if (list.Count == 0)
                Console.WriteLine("~ BOŞ ~");
            else
            {
                foreach (var listElement in list)
                {
                    if (id == listElement.Key)
                    {
                        Console.WriteLine("Title      : {0}", listElement.Value.Title);
                        Console.WriteLine("Content    : {0}", listElement.Value.Content);
                        Console.WriteLine("Person     : {0}", listElement.Value.Person);
                        Console.WriteLine("Size       : {0}", listElement.Value.Size);
                        Console.WriteLine("-");
                    }
                }
            }
        }

        private enum Size { Xs, S, M, L, Xl }

        private static string? GetSize()
        {
            try
            {
                Console.Write("Choose Size -> XS(1),S(2),M(3),L(4),XL(5) : ");
                int number = int.Parse(Console.ReadLine() ?? string.Empty);

                switch (number)
                {
                    case 1:
                        return Size.Xs.ToString();
                    case 2:
                        return Size.S.ToString();
                    case 3:
                        return Size.M.ToString();
                    case 4:
                        return Size.L.ToString();
                    case 5:
                        return Size.Xl.ToString();
                    default:
                        ConsoleUı.NoSelectionFoundUı();
                        Console.WriteLine();
                        return GetSize();
                }
            }
            catch (Exception)
            {
                ConsoleUı.NoSelectionFoundUı();
                Console.WriteLine();
                return GetSize();
            }
        }
    }
}