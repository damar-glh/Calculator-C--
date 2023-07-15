public class Car : Vehicle {
    public override void Start()
    {
        System.Console.WriteLine("Car engine started.");
    }
    public override void Stop()
    {
        System.Console.WriteLine("Car engine stopped.");
    }
}