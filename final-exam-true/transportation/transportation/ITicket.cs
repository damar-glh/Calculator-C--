// class interface untuk ticket
interface ITicket {
    // colections berupa List<TicketTransportion> tiketList 
    // untuk menyimpan objek-objek dari class TicketTransportion
    void addTicket(List<TicketTransportation> tiketList);
    void deleteTicket(List<TicketTransportation> tiketList);
}