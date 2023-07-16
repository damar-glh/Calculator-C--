public class BankAccount 
{
    // encapsulasi private field
    private int accountNumber; // untuk menyimpan nomer akun
    private decimal balance; // untuk menyimpan saldo

    public BankAccount(int accountNumber)
    {
        this.accountNumber = accountNumber;
        balance = 0;
    }

    // encapsulasi properti dengan akses read-only('get) ke private accountNumber
    public int AccountNumber
    {
        get { return accountNumber; }
    }

    // encapsulasi properti dengan akses read-only('get) ke private balance
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
            Console.WriteLine("Invalid amount.");
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
            Console.WriteLine("Invalid amount.");
        }
    }
}