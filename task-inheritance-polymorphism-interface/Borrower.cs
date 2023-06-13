public class Borrower :ItemLibrary, Loan
{
    public string Name{get; set;}
    public int Sin{get; set;}
     public override void Print()
    {
        Console.WriteLine("Borrower:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("SIN: " + SIN);
    }
     public void Borrow()
    {
        Console.WriteLine("Borrower '" + Name + "' has borrowed an item.");
    }
    public void Return(){}
} 