// Inheritance: Mewarisi sifat-sifat dari kelas Character
public class Enemy:Character {
    private int health;
    public Enemy(string name, int health) {
        Name = name;
        this.health = health;
    }

    // Encapsulation: Menggunakan properti untuk mengakses dan memodifikasi data terkait
    public int Health {
        get{return health; }
        set{health = value; }
    }

    // Polymorphism: Mengganti metode abstrak Attack() dengan implementasi khusus
    public override void Attack()
    {
        System.Console.WriteLine($"{Name} attack with claws!");
    }
}