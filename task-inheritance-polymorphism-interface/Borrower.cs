public class Borrower : ItemLibrary, ILoanable
{
    public string Name { get; set; }
    public string SIN { get; set; }

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

    public void Return()
    {
        Console.WriteLine("Borrower '" + Name + "' has returned an item.");
    }
}