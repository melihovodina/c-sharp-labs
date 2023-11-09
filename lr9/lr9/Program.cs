using System;
using System.Linq;

public struct Student
{
    public string FullName;
    public int BirthYear;
    public int GroupNumber;
    public int Physics;
    public int Math;
    public int CS;
    public int Chemistry;
    public double AverageMark;
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите фамилию и инициалы студента: ");
            students[i].FullName = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            students[i].BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            students[i].GroupNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по физике: ");
            students[i].Physics = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по математике: ");
            students[i].Math = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по информатике: ");
            students[i].CS = int.Parse(Console.ReadLine());
            Console.Write("Введите оценку по химии: ");
            students[i].Chemistry = int.Parse(Console.ReadLine());

            students[i].AverageMark = (students[i].Physics + students[i].Math + students[i].CS + students[i].Chemistry) / 4.0;
        }

        Console.Write("Введите номер группы для вывода отличников: ");
        int group = int.Parse(Console.ReadLine());

        var excellentStudents = students.Where(s => s.GroupNumber == group && s.AverageMark >= 4.5).OrderBy(s => s.FullName);

        foreach (var student in excellentStudents)
        {
            Console.WriteLine($"Фамилия и инициалы: {student.FullName}, Год рождения: {student.BirthYear}, Номер группы: {student.GroupNumber}, Средний балл: {student.AverageMark}");
        }
    }
}
