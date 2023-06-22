// base class
public class Book : Item, IBorrowable{
    public string Author{get; set;}
    public Book(string title, string author){
        Title = title;
        Author = author;
    }
    public override void Display()
    {
        System.Console.WriteLine("Book Title : " + Title);
        System.Console.WriteLine("Author     : " + Author);
    }
    public void Borrow(){
        System.Console.WriteLine("Book borrowed.");
    }
    public void Return(){
        System.Console.WriteLine("Book returned.");
    }
}