using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek akun bank dengan nomor akun tertentu
        BankAccount account = new BankAccount(0987654321);

        // Menampilkan nomor akun dan saldo awal dari objek account
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance:C}");

        // Melakukan penyetoran dan penarikan dari akun
        // Memanggil metode Deposit dan Withdraw pada objek account dengan jumlah yang sesuai
        account.Deposit(1000);
        account.Withdraw(500);

        // Menampilkan saldo terbaru setelah penyetoran dan penarikan dilakukan
        Console.WriteLine($"Balance: {account.Balance:C}");

        Console.ReadLine();
    }
}     