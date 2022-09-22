namespace ToDo;

internal static class Program
{
    private static void Main()
    {
        bool conTine;

        do
        {
            switch (GetChoose())
            {
                case 1:
                    // List board
                    ListBoard();
                    break;
                case 2:
                    // Add card
                    AddCard();
                    break;
                case 3:
                    // Delete card
                    Controls.DeleteCard();
                    break;
                case 4:
                    // Move card
                    Controls.MoveCard();
                    break;
                case 5:
                    // Update card
                    Controls.UpdateCard();
                    break;
                case 6:
                    // Exit
                    Console.WriteLine("Checking out...");
                    break;
            }

            conTine = AnotherAction();
        } while (conTine);
    }

    private static bool AnotherAction()
    {
        var control = true;
        do
        {
            try
            {
                Console.Write("Do you want to take another action? (y/n) : ");
                var answer = char.Parse(Console.ReadLine() ?? string.Empty);

                if (answer == 'y')
                {
                    Console.WriteLine("Process completed.");
                    control = false;
                    return true;
                }

                if (answer == 'n')
                {
                    Console.WriteLine("Process completed.");
                    control = false;
                    return false;
                }
            }
            catch (Exception)
            {
                ConsoleUı.NoSelectionFoundUı();
            }
        } while (control);

        ConsoleUı.NoSelectionFoundUı();
        return true;
    }

    private static int GetChoose()
    {
        try
        {
            ConsoleUı.MainMenu();
            var chooseOption = Convert.ToSByte(Console.ReadLine());

            if (chooseOption is > 0 and < 7) return chooseOption;

            ConsoleUı.NoSelectionFoundUı();
            return GetChoose();
        }
        catch (Exception)
        {
            ConsoleUı.NoSelectionFoundUı();
            return GetChoose();
        }
    }

    private static void AddCard()
    {
        var control = true;

        while (control)
            try
            {
                Console.Write("Please enter a valid ID number : ");
                var id = int.Parse(Console.ReadLine() ?? string.Empty);

                if (TeamMembers.TeamList().Contains(id))
                {
                    Controls.AddCard(id);
                    control = false;
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ID number not found.");
                Console.WriteLine();
            }
    }

    private static void ListBoard()
    {
        var control = true;

        while (control)
            try
            {
                Console.Write("Please enter a valid ID number : ");
                var id = int.Parse(Console.ReadLine() ?? string.Empty);

                if (TeamMembers.TeamList().Contains(id))
                {
                    Controls.ListBoard(id);
                    control = false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ID number not found.");
                Console.WriteLine();
            }
    }
}