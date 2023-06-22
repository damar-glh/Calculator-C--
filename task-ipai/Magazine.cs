// Derived class
public class Magazine : Item,  IBorrowable{
    public string Publisher{get; set;}
    public Magazine(string title, string publisher){
        Title = title;
        Publisher = publisher;
    }
    public override void Display()
    {
        System.Console.WriteLine("Magazine Title : " + Title);
        System.Console.WriteLine("Publisher      : " + Publisher);
    }
    public void Borrow(){
        System.Console.WriteLine("Magazine borrowed.");
    }
    public void Return(){
        System.Console.WriteLine("Magazine returned.");
    }
}