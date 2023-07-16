// absract class
public abstract class Account {
    // encapsulasi private field
    private int accountNumber; // untuk menyimpan nomer akun
    private decimal balance; // untuk menyimpan saldo
    
    public Account(int accountNumber) {
        this.accountNumber = accountNumber;
        balance = 0;
    }

    // encapsulasi properti dengan akses read-only(get) ke private accountNumber
    public int AccountNumber
    {
        get { return accountNumber; }
    }

    // encapsulasi properti dengan akses read-only(get) ke private balance
    public decimal Balance
    {
        get { return balance; }
    }
    
    // Metode Deposit dan Withdraw dideklarasikan sebagai virtual
    // agar dapat diubah perilakunya oleh kelas turunan
    public virtual void Deposit(decimal amount) {
        if (amount > 0) {
            balance += amount;
            System.Console.WriteLine($"Deposited {amount:C}. New Balance {balance:C}.");
        } else {
            System.Console.WriteLine("Invalid amount.");
        }
    }
    public virtual void Withdraw(decimal amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            System.Console.WriteLine($"Withdraw {amount:C}. New Balance {balance:C}.");
        } else {
            System.Console.WriteLine("Invalid amount.");
        }
    }
}