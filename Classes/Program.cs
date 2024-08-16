//base class or super class
class Animal
{
    public string name;

    public void display()
    {
        Console.WriteLine("I'm an animal");
    }
}
// child or derived class
class Dog : Animal
{
    public void getName()
    {
        Console.WriteLine($"My name is {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.name = "Dog_2";
        dog.display();

        dog.getName();
    }
}