class Program
{
    public static void Main(string[] args)
    {
        Keyboard genericKeyboard = new Keyboard("Generic", "Model");
        MechanicalKeyboard mechanicalKeyboard = new MechanicalKeyboard("Mechanical", "Model 1");
        MembraneKeyboard membraneKeyboard = new MembraneKeyboard("Membrane", "Model 2");

        genericKeyboard.Type();
        mechanicalKeyboard.Type();
        membraneKeyboard.Type();
    }
}