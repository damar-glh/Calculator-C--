class Keyboard
{
    protected string brand;
    protected string model;

    public Keyboard(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    public virtual void Type()
    {
        Console.WriteLine("Typing on a generic keyboard.");
    }
}