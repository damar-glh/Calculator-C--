class TicketTransportion : ITicket {
    private string name;
    private int nik;
    private int phoneNumber;
    private int veccineCardNumber;
    private string addres;

    public TicketTransportion(string name, int nik, int phoneNumber, int veccineCardNumber, int addres) {
        this.name = name;
        this.nik = nik;
        this.phoneNumber = phoneNumber;
        this.veccineCardNumber = veccineCardNumber;
        this.addres = addres;
    }

    public void ticketInformation() {
        Console.WriteLine("Informasi Tiket Transportasi");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("NIK: " + nik);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Veccine Card Number: " + veccineCardNumber);
        Console.WriteLine("Addres: " + addres);
    }

    public void addTicket(List<TicketTransportion> ticketList) {
        ticketList.Add(this);
        Console.WriteLine("Ticket add.");
    }

    public void deleteTicket(List<TicketTransportion> ticketList) {
        ticketList.Remove(this);
        Console.WriteLine("Ticket delete.");
    }
}