using Homework.Models;

Group group1 = new(5);
Group group2 = new(5);
Group group3 = new(5);

Student student1 = new("Nijat Heyderov", 10);
Student student2 = new("Leman Cananova", 80);
Student student3 = new("Mehemmed Ali", 70);

group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);

foreach (var item in group1.GetAllStudents())
{
    item.StudentInfo();
}

group1.GetStudent(3);