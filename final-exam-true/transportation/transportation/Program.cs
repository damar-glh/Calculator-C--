class Program {
    static void Main(string[] args) {
        List<TicketTransportion> tiketList = new List<TicketTransportion>();

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
            System.Console.Write("Enter your choice : ");
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
                    TicketTransportion ticket = new TicketTransportion(name, nik, phoneNumber, veccineCardId, addres);
                    ticket.addTicket(tiketList);
                    break;
                case 2:
                    if (tiketList.Count > 0) {
                        Console.WriteLine("=== Tiket saat ini ===");
                        for (int i = 0; i < tiketList.Count; i++) {
                            Console.WriteLine($"Tiket {i + 1}:");
                            tiketList[i].ticketInformation();
                            Console.WriteLine();
                        }
                        
                        Console.Write("Pilih tiket yang akan dihapus (1-" + tiketList.Count + "): ");
                        int nomorTiket = int.Parse(Console.ReadLine());

                        if (nomorTiket >= 1 && nomorTiket <= tiketList.Count) {
                            TicketTransportion tiketTerpilih = tiketList[nomorTiket - 1];
                            tiketTerpilih.deleteTicket(tiketList);
                        } else {
                            Console.WriteLine("Tiket tidak valid!");
                        }
                    } else {
                        Console.WriteLine("Belum ada tiket yang tersedia!");
                    }
                    break;
                case 3:
                    if (tiketList.Count > 0) {
                        Console.WriteLine("=== Tiket saat ini ===");
                        for (int i = 0; i < tiketList.Count; i++) {
                            Console.WriteLine($"Tiket {i + 1}:");
                            tiketList[i].ticketInformation();
                            Console.WriteLine();
                        }
                    } else {
                        Console.WriteLine("Belum ada tiket yang tersedia!");
                    }
                    break;
            }
        }
    }
}