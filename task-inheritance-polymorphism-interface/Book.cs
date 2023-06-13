public class Book : ItemLibrary, ILoanable
{
    public string Author { get; set; }

    public override void Print()
    {
        Console.WriteLine("Book:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }

    public void Borrow()
    {
        Console.WriteLine("Book '" + Title + "' has been borrowed.");
    }

    public void Return()
    {
        Console.WriteLine("Book '" + Title + "' has been returned.");
    }
}