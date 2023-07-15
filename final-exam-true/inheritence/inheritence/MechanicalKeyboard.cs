class MechanicalKeyboard : Keyboard
{
    public MechanicalKeyboard(string brand, string model) : base(brand, model)
    {
    }

    public override void Type()
    {
        Console.WriteLine("Typing on a mechanical keyboard.");
    }
}