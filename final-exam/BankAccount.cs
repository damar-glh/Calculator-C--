// inheritance class impelementation
public class BankAccount : Account {
    public BankAccount(int accountNumber) : base (accountNumber){}

    // polymorphism ditandai dengan ovveride
    public override void Deposit(decimal amount)
    {
        // Memanggil implementasi dari kelas dasar (Account)
        // namun bisa juga mengubah method ini jika diperlukan
        base.Deposit(amount);
    }
    public override void Withdraw(decimal amount)
    {
        // Memanggil implementasi dari kelas dasar (Account)
        // namun bisa juga mengubah method ini jika diperlukan
        base.Withdraw(amount);
    }
}