class Program
{
    static void Main(string[] args)
    {
        List<TicketTransportasi> tiketList = new List<TicketTransportasi>();

        // menu
        System.Console.WriteLine("==========================");
        System.Console.WriteLine("=   Ticket Transportasi  =");
        System.Console.WriteLine("==========================");
        System.Console.WriteLine("1. Add Ticket");
        System.Console.WriteLine("2. Delete Ticket");
        System.Console.WriteLine("3. Ticket List");
        System.Console.WriteLine("==========================");
        System.Console.WriteLine("Enter your choice : ");
        int choice = int.Parse(Console.Read());
        switch (choice) {
            case "1":
                System.Console.WriteLine("Enter your name : ");
                string name = Console.Read();
                
        }
    }
}