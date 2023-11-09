using System;
using System.Collections.Generic;
using System.Linq;
Console.Write("Введите количество студентов: ");
int studentCount = Convert.ToInt32(Console.ReadLine());
List<Student> students = new List<Student>();
for (int i = 0; i < studentCount; i++)
{
    Student student = new Student();
    Console.Write("Введите фамилию и инициалы студента: ");
    student.Name = Console.ReadLine();
    Console.Write("Введите год рождения студента: ");
    student.BirthYear = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер группы студента: ");
    student.GroupNumber = Convert.ToInt32(Console.ReadLine());
    student.SemesterGrades = new Grades[4];
    double totalGrades = 0;
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"Введите оценку за {Enum.GetName(typeof(Grades), j)}: ");
        student.SemesterGrades[j] = (Grades)Convert.ToInt32(Console.ReadLine());
        totalGrades += (int)student.SemesterGrades[j];
    }
    student.AverageGrade = totalGrades / 4;
    students.Add(student);
}
students = students.OrderBy(s => s.Name).ToList();
foreach (var student in students)
{
    Console.WriteLine($"Студент: {student.Name}, Год рождения: {student.BirthYear}, Номер группы: {student.GroupNumber}, Средний балл: {student.AverageGrade}");
}
students = students.OrderByDescending(s => s.AverageGrade).ToList();
foreach (var student in students)
{
    Console.WriteLine($"Студент: {student.Name}, Год рождения: {student.BirthYear}, Номер группы: {student.GroupNumber}, Средний балл: {student.AverageGrade}");
}
public enum Grades
{
    Physics,
    Math,
    ComputerScience,
    Chemistry
}
public struct Student
{
    public string Name;
    public int BirthYear;
    public int GroupNumber;
    public Grades[] SemesterGrades;
    public double AverageGrade;
}