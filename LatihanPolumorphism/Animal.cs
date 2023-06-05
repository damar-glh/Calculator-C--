public class Animal {
    public string Name {get; set;}

    public virtual void Speak(){
        Console.WriteLine("The Animal speaks");
    }
}