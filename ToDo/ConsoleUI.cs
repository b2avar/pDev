namespace ToDo;

public static class ConsoleUı
{
    public static void MainMenu()
    {
        Console.WriteLine("ToDo List Menu");
        Console.WriteLine("*******************************************");

        Console.WriteLine("(1) List Board");
        Console.WriteLine("(2) Add Card to Board");
        Console.WriteLine("(3) Delete Card from Board");
        Console.WriteLine("(4) Move Card");
        Console.WriteLine("(5) Update Card");
        Console.WriteLine("(6) Exit");
        Console.Write("Please enter the transaction number you want to make : ");
    }

    public static void NoSelectionFoundUı()
    {
        Console.WriteLine();
        Console.WriteLine("No selection found!");
        Console.WriteLine("Please enter one of the characters or numbers on the screen according to the operation you want to do.!");
        Console.WriteLine();
    }

    public static void ListBoardUı(string lineName)
    {
        Console.WriteLine(lineName);
        Console.WriteLine("************************");
        Console.WriteLine();
    }

    public static void TwoFactorSelectionUı()
    {
        Console.WriteLine(
            " The card matching your search criteria was not found on the board. Please make a selection.");
        Console.WriteLine("* to terminate the process : (1)");
        Console.WriteLine("* to try again             : (2)");
    }

    public static void CardInfoFoundUı(int key, Dictionary<int, CardList> list)
    {
        Console.WriteLine("Card Information Found:");
        Console.WriteLine("**************************************");
        Console.WriteLine("Title      : {0}", list[key].Title);
        Console.WriteLine("Content    : {0}", list[key].Content);
        Console.WriteLine("Person     : {0}", list[key].Person);
        Console.WriteLine("Size       : {0}", list[key].Size);
    }

    public static void CardTitle()
    {
        Console.WriteLine("First you need to choose the card you want to move, update or delete.");
        Console.Write("Please write the card title : ");
    }

    public static void MoveCarUı()
    {
        Console.WriteLine();
        Console.WriteLine("(1) TODO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");
    }

    public static void ThreeSpace()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}