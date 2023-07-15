public class Program
{
    public static void Main(string[] args)
    {
        Vehicle car = new Car();
        car.Start();
        car.Stop();

        Vehicle motorcycle = new Motorcycle();
        motorcycle.Start();
        motorcycle.Stop();

        Console.ReadLine();
    }
}