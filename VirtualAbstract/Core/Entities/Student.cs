namespace Core.Entities;

public class Student : Person
{
    public int Point { get; set; }

    public Student(string name, byte age, int point) : base(name, age)
    {
        Point = point;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"{Name} {Age} {Point}");
    }

    public override void Eat()
    {
        Console.WriteLine("Eat as student");
    }

    public override string ToString()
    {
        return $"{Name} {Age} {Point}";
    }
}
