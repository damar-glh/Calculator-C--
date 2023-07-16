public class Program
{
    public static void Main(string[] args)
    {
        // buat instance objek dari class BankAccount
        BankAccount account = new BankAccount(1826749328);

        // Menampilkan nomor akun dan saldo awal 
        // menggunakan string interpolation.
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Initial Balance: {account.Balance:C}");

        // Memanggil metode Deposit untuk menambahkan saldo
        account.Deposit(1500);
        // Memanggil metode Withdraw untuk mengurangi saldo
        account.Withdraw(500);

        // Menampilkan saldo terkini
        Console.WriteLine($"Curenct Balance: {account.Balance:C}");

        Console.ReadLine();
    }
}