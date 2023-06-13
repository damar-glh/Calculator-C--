public class Program
{
    static void Main(string[] args)
    {
        Book book = new Book()
        {
            Title = "Harry Potter and the Deathly Hallows",
            Author = "J.K. Rowling"
        };

        Borrower borrower = new Borrower()
        {
            Name = "John Doe",
            SIN = "1234567890"
        };

        Returner returner = new Returner()
        {
            Name = "Jane Smith",
            SIN = "0987654321"
        };

        ItemLibrary[] items = new ItemLibrary[] { book, borrower, returner };

        foreach (ItemLibrary item in items)
        {
            item.Print();

            if (item is ILoanable)
            {
                ILoanable loanableItem = (ILoanable)item;
                loanableItem.Borrow();
                loanableItem.Return();
            }

            Console.WriteLine();
        }
    }
}