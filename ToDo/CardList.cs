namespace ToDo{

    public class CardList{
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? Person { get; set; }

        public string? Size { get; set; }

        public CardList(string? title, string? content, string? person, string? size)
        {
            this.Title = title;
            this.Content = content;
            this.Person = person;
            this.Size = size;
        }
    }
}