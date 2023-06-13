public class Returner : ItemLibrary, ILoanable
{
    public string Name { get; set; }
    public string SIN { get; set; }

    public override void Print()
    {
        Console.WriteLine("Returner:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("SIN: " + SIN);
    }

    public void Borrow()
    {
        Console.WriteLine("Returner '" + Name + "' has borrowed an item.");
    }

    public void Return()
    {
        Console.WriteLine("Returner '" + Name + "' has returned an item.");
    }
}