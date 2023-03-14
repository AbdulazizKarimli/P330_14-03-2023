namespace Core.Entities;

public abstract class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public Person(string name, byte age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Eat();

    public virtual void GetInfo()
    {
        Console.WriteLine($"{Name} {Age}");
    }
}
