namespace Core.Entities;

public class Engineer : Person
{
    public int Salary { get; set; }
    public Engineer(string name, byte age, int salary) : base(name, age)
    {
        Salary = salary;
    }

    public sealed override void GetInfo()
    {
        Console.WriteLine($"{Name} {Age} {Salary}");
    }

    public override void Eat()
    {
        Console.WriteLine("Eat as Engineer");
    }
}
