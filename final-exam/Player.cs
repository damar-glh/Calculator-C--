// Inheritance: Mewarisi sifat-sifat dari kelas Character

public class Player : Character {
    private int experiencePoints;
    public Player(string name, int experiencePoints){
        Name = name;
        this.experiencePoints = experiencePoints;
    }

    // Encapsulation: Menggunakan properti untuk mengakses dan memodifikasi data terkait
    public int experiencePoints {
        get{return experiencePoints; }
        set{experiencePoints = value; }
    }

    // Polymorphism: Mengganti metode abstrak Attack() dengan implementasi khusus
    public override void Attack()
    {
        System.Console.WriteLine($"{Name} attack with a sword!");
    }
}