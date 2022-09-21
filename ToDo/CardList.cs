namespace ToDo;

public class CardList
{
    public CardList(string? title, string? content, string? person, string? size)
    {
        Title = title;
        Content = content;
        Person = person;
        Size = size;
    }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Person { get; set; }

    public string? Size { get; set; }
}