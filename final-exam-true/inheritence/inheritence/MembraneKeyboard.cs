class MembraneKeyboard : Keyboard
{
    public MembraneKeyboard(string brand, string model) : base(brand, model)
    {
    }

    public override void Type()
    {
        Console.WriteLine("Typing on a membrane keyboard.");
    }
}
