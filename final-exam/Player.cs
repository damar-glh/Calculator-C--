// Inheritance: Mewarisi sifat-sifat dari kelas Character

public class Player : Character {
    public Player(string name) {
        Name = name;
    }

    // Polymorphism: Mengganti metode abstrak Attack() dengan implementasi khusus
    public override void Attack()
    {
        System.Console.WriteLine($"{Name} attack with a sword!");
    }
}