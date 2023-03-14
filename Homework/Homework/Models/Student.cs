namespace Homework.Models;

public class Student
{
    private static int _id;

    public int Id { get; }
    public string Fullname { get; set; }
    public int Point { get; set; }

    public Student(string fullname, int point)
    {
        Id = ++_id;
        Fullname = fullname;
        Point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"{Id} {Fullname} {Point}");
    }
}