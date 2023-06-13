public class Returner :ItemLibrary, Loan
{
    public string Name{get; set;}
    public int Sin{get; set;}
    public override void Print()
    {
        Console.WriteLine("Returner:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("SIN: " + SIN);
    }
    public void Borrow(){}
    public void Return()
    {
        System.Console.WriteLine("Book " + title + " has been returned by " + name + " with sin " + sin);
    }
} 