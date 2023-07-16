class Program {
    static void Main(string[] args) {
        List<TicketTransportasi> tiketList = new List<TicketTransportasi>();

        bool isReply = true;
        while (isReply) {
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
                    Console.Write("Enter your nik : ");
                    long nik = long.Parse(Console.ReadLine());
                    Console.Write("Enter your phone number : ");
                    long phoneNumber = long.Parse(Console.ReadLine());
                    Console.Write("Enter your veccine card id : ");
                    string nomorKartuVaksin = Console.ReadLine();
                    Console.Write("Enter your addres : ");
                    string alamatRumah = Console.ReadLine();
                    TicketTransportasi tiket = new TicketTransportasi(nama, nik, nomorTelepon, nomorKartuVaksin, alamatRumah);
                    tiket.AddTicket(tiketList);
                    break;
                
            }
        }
    }
}