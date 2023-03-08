using System;

public class Animal
{
    public string Name { get; set; }

    public Animal()
    {
        Name = "Lukas";
    }

    public Animal(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}