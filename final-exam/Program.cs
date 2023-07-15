public class Program {
    public static void Main(string[] args) {
        Player player = new Player("Player 1");
        Enemy enemy = new Enemy("Wizard", 100);

        player.Attack();
        enemy.Attack();

        // Polymorphism: Menggunakan referensi kelas Character untuk objek player dan enemy
        Character character1 = player;
        Character character2 = enemy;

        character1.Attack();
        character2.Attack();
    }
}