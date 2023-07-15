public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek akun bank dengan nomor akun tertentu
        // Penjelasan: Membuat objek BankAccount dengan menggunakan nomor akun "1234567890"
        BankAccount account = new BankAccount("1234567890");

        // Menampilkan nomor akun dan saldo awal
        // Penjelasan: Menampilkan nomor akun dan saldo awal dari objek account
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance:C}");

        // Melakukan penyetoran dan penarikan dari akun
        // Penjelasan: Memanggil metode Deposit dan Withdraw pada objek account dengan jumlah yang sesuai
        account.Deposit(1000);
        account.Withdraw(500);

        // Menampilkan saldo terbaru
        // Penjelasan: Menampilkan saldo terbaru setelah penyetoran dan penarikan dilakukan
        Console.WriteLine($"Balance: {account.Balance:C}");

        Console.ReadLine();
    }
}
