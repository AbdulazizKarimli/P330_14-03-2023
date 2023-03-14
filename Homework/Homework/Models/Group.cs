namespace Homework.Models;

public class Group
{
    private static int _groupNo = 99;
    private int _studentLimit;

    public string GroupNo { get; }
    public int StudentLimit 
    {
        get => _studentLimit; 
        set
        {
            if(value >= 5 && value <= 18)
                _studentLimit = value;
        }
    }

    private Student[] students;

    public Group(int studentLimit)
    {
        GroupNo = $"P{++_groupNo}";
        students = new Student[0];
        StudentLimit = studentLimit;
    }

    public void AddStudent(Student student)
    {
        if(students.Length < StudentLimit)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }

    public Student GetStudent(int id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
                return student;
        }

        return null;
    }

    public Student[] GetAllStudents()
    {
        return students;
    }
}