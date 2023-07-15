public class BankAccount
{
    private string accountNumber; // Private field untuk menyimpan nomor akun
    private decimal balance; // Private field untuk menyimpan saldo

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0;
    }

    // Properti AccountNumber digunakan untuk membaca nomor akun
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Properti Balance digunakan untuk membaca saldo
    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        // Metode Deposit digunakan untuk melakukan penyetoran ke akun
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance is {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Deposit amount must be greater than 0.");
        }
    }

    public void Withdraw(decimal amount)
    {
        // Metode Withdraw digunakan untuk melakukan penarikan dari akun
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance is {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Withdrawal amount must be greater than 0 and less than or equal to the balance.");
        }
    }
}
