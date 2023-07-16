using System.Collections.Generic;
class Program {
    static void Main(string[] args) {
        List<TicketTransportation> tiketList = new List<TicketTransportation>();

        bool isReply = true;
        while (isReply) {
            // menu
            Console.WriteLine("============================");
            Console.WriteLine("=   Ticket Transportation  =");
            Console.WriteLine("============================");
            Console.WriteLine("1. Add Ticket");
            Console.WriteLine("2. Delete Ticket");
            Console.WriteLine("3. Ticket List");
            Console.WriteLine("4. Exit");
            Console.WriteLine("==========================");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    System.Console.Write("Enter your name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your nik : ");
                    long nik = long.Parse(Console.ReadLine());
                    Console.Write("Enter your phone number : ");
                    long phoneNumber = long.Parse(Console.ReadLine());
                    Console.Write("Enter your veccine card id : ");
                    string veccineCardId = Console.ReadLine();
                    Console.Write("Enter your addres : ");
                    string addres = Console.ReadLine();
                    TicketTransportation ticket = new TicketTransportation(name, nik, phoneNumber, veccineCardId, addres);
                    ticket.addTicket(tiketList);
                    break;
                case 2:
                    if (tiketList.Count > 0) {                        
                        for (int i = 0; i < tiketList.Count; i++) {
                            Console.WriteLine($"============== Tiket {i + 1} ==============");
                            tiketList[i].ticketInformation();
                            Console.WriteLine();
                        }
                        Console.Write("Select the ticket to delete : ");
                        int numTicket = int.Parse(Console.ReadLine());

                        if (numTicket >= 1 && numTicket <= tiketList.Count) {
                            TicketTransportation selecTicket = tiketList[numTicket - 1];
                            selecTicket.deleteTicket(tiketList);
                        } else {
                            Console.WriteLine("Invalid ticket number !!!");
                        }
                    } else {
                        Console.WriteLine("No tickets available right now !!!");
                    }
                    break;
                case 3:
                    if (tiketList.Count > 0) {
                        for (int i = 0; i < tiketList.Count; i++) {
                            Console.WriteLine($"============== Tiket {i + 1} ==============");
                            tiketList[i].ticketInformation();
                            Console.WriteLine();
                        }
                    } else {
                        Console.WriteLine("No tickets available right now !!!");
                    }
                    break;
                case 4:
                    isReply = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice !!!");
                    break;
            }
        }
    }
}
