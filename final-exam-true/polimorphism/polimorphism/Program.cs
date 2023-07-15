public class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle1 = new Car();
        vehicle1.StartEngine();  // Output: Starting the car engine...

        Vehicle vehicle2 = new Motorcycle();
        vehicle2.StartEngine();  // Output: Starting the motorcycle engine...

        Console.ReadLine();
    }
}