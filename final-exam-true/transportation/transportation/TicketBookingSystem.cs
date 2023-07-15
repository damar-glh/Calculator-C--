class TicketBookingSystem {
    public void StartBookingProcess() {
        Ticket ticket = new Ticket();

        System.Console.WriteLine("Enter your name : ");
        ticket.Name = Console.Read();
        
        System.Console.WriteLine("Enter your NIK : ");
        ticket.NIK = ((char)Console.Read()).ToString();
        
        System.Console.WriteLine("Enter your phone number : ");
        ticket.PhoneNumber = ((char)Console.Read()).ToString();
        
        System.Console.WriteLine("Enter your veccine crd number : ");
        ticket.VeccineCardNumber = ((char)Console.Read()).ToString();
        
        System.Console.WriteLine("Enter your address : ");
        ticket.Address = Console.Read();
    }
}