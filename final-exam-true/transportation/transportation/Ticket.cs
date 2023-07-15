class Ticket {
    public string Name { get; set; }
    public int NIK { get; set; }
    public int PhoneNumber { get; set; }
    public int VeccineCardNumber { get; set; }
    public string Address { get; set; }

    public void DisplayTicketInformation() {
        System.Console.WriteLine("Name : " + Name);
        System.Console.WriteLine("NIK : " + NIK);
        System.Console.WriteLine("Phone Num. : " + PhoneNumber);
        System.Console.WriteLine("Veccine Card Num. : " + VeccineCardNumber);
        System.Console.WriteLine("Address : " + Address);
    }
}