class TicketTransportation : ITicket {
    private string name;
    private long nik;
    private long phoneNumber;
    private string veccineCardId;
    private string addres;

    public TicketTransportation(string name, long nik, long phoneNumber, string veccineCardId, string addres) {
        this.name = name;
        this.nik = nik;
        this.phoneNumber = phoneNumber;
        this.veccineCardId = veccineCardId;
        this.addres = addres;
    }

    public void ticketInformation() {
        Console.WriteLine("=====================================");
        Console.WriteLine("= Transportation Ticket Information =");
        Console.WriteLine("=====================================");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("NIK: " + nik);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Veccine Card Number: " + veccineCardId);
        Console.WriteLine("Addres: " + addres);
    }

    public void addTicket(List<TicketTransportation> ticketList) {
        ticketList.Add(this);
        Console.WriteLine("Ticket add !!!.");
    }

    public void deleteTicket(List<TicketTransportation> ticketList) {
        ticketList.Remove(this);
        Console.WriteLine("Ticket delete !!!.");
    }
}