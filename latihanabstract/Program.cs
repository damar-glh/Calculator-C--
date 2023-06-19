class Program{
    public static void Main(string[] args){
        Shape circle = new Circle();
        circle.Display();
        circle.CalculateArea(); // memanggil abstract method Calculate pada objec circle

        Shape rectangle = new Rectangle();
        rectangle.Display();
        rectangle.CalculateArea(); // memanggil abstract method Calculate pada objec rectangle
    }
}