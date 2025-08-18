internal class Program
{
    private static void Main(string[] args)
    {
        string[] articleData = Console.ReadLine().Split(", ");
        string title = articleData[0];
        string content = articleData[1];
        string author = articleData[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] cmdArg = Console.ReadLine().Split(": ");
            string command = cmdArg[0];
            string newData = cmdArg[1];

            if (command == "Edit")
            {
                article.Edit(newData);
            }
            else if (command == "ChangeAuthor")
            {
                article.ChangeAuthor(newData);
            }
            else if (command == "Rename")
            {
                article.Rename(newData);
            }
        }

        Console.WriteLine(article.ToString());
    }
}

public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; private set; }

    public string Content { get; private set; }

    public string Author { get; private set; }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}