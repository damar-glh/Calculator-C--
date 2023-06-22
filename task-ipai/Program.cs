// main class
class Program{
    public static void Main(string[] args){
        Book book = new Book ("Harry Potter and the Half-Blood Prince", "J.K. Rowling");
        Magazine magazine = new Magazine("World Film Association","WMP Film Institute");

        Library.DisplayItem(book);
        book.Borrow();
        book.Return();

        System.Console.WriteLine();
        
        Library.DisplayItem(magazine);
        magazine.Borrow();
        magazine.Return();
    }
}