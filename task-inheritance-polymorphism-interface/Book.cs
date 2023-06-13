
class Book : ItemLibrary, Loan
{
    public string Author {get; set;}
    public override void Print()
    {
        Console.WriteLine("Book   :");
        Console.WriteLine("Title  : " + Title);
        Console.WriteLine("Author : " + Author);
    }
    public void Borrow()
    {
        System.Console.WriteLine("Book " + Title + " has been borrowed.");
    }
    public void Return()
    {
        System.Console.WriteLine("Book " + Title + " has been return.");
    }
} 