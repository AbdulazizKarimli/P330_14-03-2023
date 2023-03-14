using Core.Entities;
using System.Text;
using Utils.Enums;

//Person person = new("Kenan", 20);
//Student student = new("Kenan", 20, 75);
//Engineer engineer = new("Mehemmed Ali", 18, 300);
//BackendEngineer backendEngineer = new("Musa", 19, 350, 5);

//Person[] people = new Person[] { /*person,*/ student, engineer, backendEngineer };

//foreach (var item in people)
//{
//    item.GetInfo();
//}

//student.Eat();
//engineer.Eat();

//person.GetInfo();
//student.GetInfo();

//int month = int.Parse(Console.ReadLine());

//string monthName = month switch
//{
//    (int)Month.Yanvar => "Yanvar",
//    (int)Month.Fevral => "Fevral",
//    (int)Month.Mart => "Mart",
//    (int)Month.Aprel => "Aprel",
//    _ => "Diger bir ay"
//};

//foreach (var item in Enum.GetValues(typeof(Month)))
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(monthName);

Student student = new("Togrul", 19, 51);

Console.WriteLine(student);