class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di Aplikasi Pemesanan Tiket");
            Console.WriteLine("----------------------------------------");

            TicketBookingSystem bookingSystem = new TicketBookingSystem();
            bookingSystem.StartBookingProcess();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }