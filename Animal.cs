class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Lion");
        myAnimal.Move();
        myAnimal.Sleep();

        Animal anotherAnimal = new Animal();
        anotherAnimal.Name = "Tiger";
        anotherAnimal.Move();
        anotherAnimal.Sleep();
    }
}