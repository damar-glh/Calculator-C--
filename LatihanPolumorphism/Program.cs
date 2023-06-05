static void Main(string[] args){
    Animal animal = new Animal();
    animal.Speak();
    
    Cat cat = new Cat();
    animal = cat;
    // cat.Speak();
    animal.Speak();

    Chicken chicken = new Chicken();
    animal = chicken;
    // chicken.Speak();
    animal.Speak();

    Dog dog = new Dog();
    animal = dog;
    // dog.Speak();
    animal.Speak();
}