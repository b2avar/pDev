namespace ToDo;

public static class List
{
    public static readonly Dictionary<int, CardList> ToDoLine = new();
    public static readonly Dictionary<int, CardList> İnProgressLine = new();
    public static readonly Dictionary<int, CardList> DoneLine = new();
}