namespace ToDo;

public static class Controls
{
    private static string? _title;
    private static string? _content;
    private static string? _person;
    private static string? _size;

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
        var title = Console.ReadLine();
        Console.Write("Enter Content                               : ");
        var content = Console.ReadLine();
        Console.Write("Enter Person                                : ");
        var person = Console.ReadLine();
        var size = GetSize();
        List.ToDoLine.Add(id, new CardList(title, content, person, size));
    }

    //(3) Delete card from board
    public static void DeleteCard()
    {
        var control = true;
        do
        {
            ConsoleUı.CardTitle();
            var title = Console.ReadLine();
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
                    var control2 = true;
                    do
                    {
                        try
                        {
                            ConsoleUı.TwoFactorSelectionUı();
                            var s = Console.ReadLine();

                            if (s == "1")
                            {
                                Console.WriteLine("Process terminated.");
                                control2 = false;
                                control = false;
                            }

                            else if (s == "2")
                            {
                                control2 = false;
                            }
                        }
                        catch (Exception)
                        {
                            ConsoleUı.NoSelectionFoundUı();
                            Console.WriteLine();
                        }
                    } while (control2);
                }
            }
        } while (control);
    }

    //(4) Move card
    public static void MoveCard()
    {
        var select = true;
        do
        {
            try
            {
                ConsoleUı.CardTitle();
                var title = Console.ReadLine();
                var myKeyToDo = List.ToDoLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyInPro = List.İnProgressLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyDone = List.DoneLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;

                if (List.ToDoLine.Keys.Contains(myKeyToDo) || List.İnProgressLine.Keys.Contains(myKeyInPro) ||
                    List.DoneLine.Keys.Contains(myKeyDone))
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

                    ConsoleUı.MoveCarUı();
                    bool c = true;

                    do
                    {
                        try
                        {
                            Console.Write("Please select the Line you want to move : ");
                            var choose = Console.ReadLine();

                            switch (choose)
                            {
                                case "1":
                                    if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                    {
                                        List.ToDoLine.Add(myKeyToDo, new CardList(_title, _content, _person, _size));
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }
                                    else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                    {
                                        List.ToDoLine.Add(myKeyInPro, new CardList(_title, _content, _person, _size));
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }

                                    else if (List.DoneLine.Keys.Contains(myKeyDone))
                                    {
                                        List.ToDoLine.Add(myKeyDone, new CardList(_title, _content, _person, _size));
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }

                                    select = false;
                                    Console.WriteLine("Transaction successful");
                                    break;

                                case "2":
                                    if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                    {
                                        List.İnProgressLine.Add(myKeyToDo,
                                            new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }
                                    else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                    {
                                        List.İnProgressLine.Add(myKeyInPro,
                                            new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }

                                    else if (List.DoneLine.Keys.Contains(myKeyDone))
                                    {
                                        List.İnProgressLine.Add(myKeyDone,
                                            new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.DoneLine.Remove(myKeyDone);
                                        c = false;
                                    }

                                    select = false;
                                    Console.WriteLine("Transaction successful");
                                    break;

                                case "3":
                                    if (List.ToDoLine.Keys.Contains(myKeyToDo))
                                    {
                                        List.DoneLine.Add(myKeyToDo, new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        c = false;
                                    }
                                    else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                                    {
                                        List.DoneLine.Add(myKeyInPro, new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        c = false;
                                    }

                                    else if (List.DoneLine.Keys.Contains(myKeyDone))
                                    {
                                        List.DoneLine.Add(myKeyDone, new CardList(_title, _content, _person, _size));
                                        List.ToDoLine.Remove(myKeyToDo);
                                        List.İnProgressLine.Remove(myKeyInPro);
                                        c = false;
                                    }

                                    select = false;
                                    Console.WriteLine("Transaction successful");
                                    break;
                            }
                        }

                        catch (Exception)
                        {
                            var b = true;
                            do
                            {
                                try
                                {
                                    ConsoleUı.TwoFactorSelectionUı();
                                    var s = Console.ReadLine();

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
                            } while (b);
                        }
                    } while (c);
                }

                else
                {
                    var cnt = true;
                    do
                    {
                        try
                        {
                            ConsoleUı.TwoFactorSelectionUı();
                            var s = Console.ReadLine();

                            if (s == "1")
                            {
                                Console.WriteLine("Process terminated.");
                                cnt = false;
                                select = false;
                            }

                            else if (s == "2")
                            {
                                cnt = false;
                            }
                        }
                        catch (Exception)
                        {
                            ConsoleUı.NoSelectionFoundUı();
                            Console.WriteLine();
                        }
                    } while (cnt);
                }
            }

            catch (Exception)
            {
                ConsoleUı.TwoFactorSelectionUı();
            }
        } while (select);
    }

    //(05) Update card
    public static void UpdateCard()
    {
        var select = true;
        do
        {
            try
            {
                ConsoleUı.CardTitle();
                var title = Console.ReadLine();
                var myKeyToDo = List.ToDoLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyInPro = List.İnProgressLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;
                var myKeyDone = List.DoneLine.FirstOrDefault(cardList => cardList.Value.Title == title).Key;

                if (List.ToDoLine.Keys.Contains(myKeyToDo))
                {
                    select = UpdateNewCardAdd(List.ToDoLine, myKeyToDo);
                    Console.WriteLine("Transaction successful");
                }

                else if (List.İnProgressLine.Keys.Contains(myKeyInPro))
                {
                    select = UpdateNewCardAdd(List.İnProgressLine, myKeyInPro);
                    Console.WriteLine("Transaction successful");
                }

                else if (List.DoneLine.Keys.Contains(myKeyDone))
                {
                    select = UpdateNewCardAdd(List.DoneLine, myKeyDone);
                    Console.WriteLine("Transaction successful");
                }

                else
                {
                    var control = true;
                    do
                    {
                        try
                        {
                            ConsoleUı.TwoFactorSelectionUı();
                            var s = Console.ReadLine();

                            if (s == "1")
                            {
                                Console.WriteLine("Process terminated.");
                                control = false;
                                select = false;
                            }

                            else if (s == "2")
                            {
                                control = false;
                            }
                        }
                        catch (Exception)
                        {
                            ConsoleUı.NoSelectionFoundUı();
                            Console.WriteLine();
                        }
                    } while (control);
                }
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
        var title = Console.ReadLine();
        Console.Write("Enter Content                               : ");
        var content = Console.ReadLine();
        Console.Write("Enter Person                                : ");
        var person = Console.ReadLine();
        var size = GetSize();
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
            foreach (var listElement in list)
                if (id == listElement.Key)
                {
                    Console.WriteLine("Title      : {0}", listElement.Value.Title);
                    Console.WriteLine("Content    : {0}", listElement.Value.Content);
                    Console.WriteLine("Person     : {0}", listElement.Value.Person);
                    Console.WriteLine("Size       : {0}", listElement.Value.Size);
                    Console.WriteLine("-");
                }
    }

    private static string? GetSize()
    {
        try
        {
            Console.Write("Choose Size -> XS(1),S(2),M(3),L(4),XL(5) : ");
            var number = int.Parse(Console.ReadLine() ?? string.Empty);

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

    private enum Size
    {
        Xs,
        S,
        M,
        L,
        Xl
    }
}