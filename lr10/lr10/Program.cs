using System;
using System.Diagnostics;
//1
BaseClass baseObject = new BaseClass();
ChildClass1 child1Object = new ChildClass1();
ChildClass2 child2Object = new ChildClass2();
ChildClass3 child3Object = new ChildClass3();
child1Object.VirtualMethod();
child2Object.VirtualMethod();
child3Object.VirtualMethod();
public class BaseClass
{
    public virtual void VirtualMethod()
    {
        Console.WriteLine("Вызов из базового класса");
    }
}
public class ChildClass1 : BaseClass
{
    public override void VirtualMethod()
    {
        Console.WriteLine("Вызов из ChildClass1");
    }
}
public class ChildClass2 : BaseClass
{
    public override void VirtualMethod()
    {
        Console.WriteLine("Вызов из ChildClass2");
    }
}
public sealed class ChildClass3 : BaseClass
{
}

//2
//Note1 note1 = new Note1();
//note1.InputFromKeyboard();
//note1.Display();
//Note1 note2 = new Note1("Встреча с Полиной");
//note2.Display();
//public class Note
//{
//    public Note()
//    {
//        Console.WriteLine("Вызван конструктор без параметров для класса Note");
//    }
//}
//public class Note1 : Note
//{
//    public string MeetingWith { get; set; }
//    public Note1() : base()
//    {
//        Console.WriteLine("Вызван конструктор без параметров для класса Note1");
//    }
//    public Note1(string meetingWith) : base()
//    {
//        MeetingWith = meetingWith;
//        Console.WriteLine($"Вызван конструктор с параметрами для класса Note1. Значение MeetingWith: {MeetingWith}");
//    }
//    public void InputFromKeyboard()
//    {
//        Console.Write("Введите значение для поля MeetingWith: ");
//        MeetingWith = Console.ReadLine();
//    }
//    public void Display()
//    {
//        Console.WriteLine($"Значение поля MeetingWith: {MeetingWith}");
//    }
//}

//3
//Truck truck1 = new Truck();
//Truck truck2 = new Truck("Volvo", 6, 400, 20000);
//truck2.Display();
//truck2.SetBrand("Scania");
//truck2.SetLoadCapacity(25000);
//truck2.Display();
//try
//{
//    truck2.SetLoadCapacity(-100);
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine(e.Message);
//}
//public class Car
//{
//    public string Brand { get; set; }
//    public int Cylinders { get; set; }
//    public int Power { get; set; }
//    public Car()
//    {
//        Console.WriteLine("Вызван конструктор без параметров для класса Car");
//    }
//    public Car(string brand, int cylinders, int power)
//    {
//        Brand = brand;
//        Cylinders = cylinders;
//        Power = power;
//        Console.WriteLine($"Вызван конструктор с параметрами для класса Car. Значения: Brand - {Brand}, Cylinders - {Cylinders}, Power - {Power}");
//    }
//    public void Display()
//    {
//        Console.WriteLine($"Car: Brand - {Brand}, Cylinders - {Cylinders}, Power - {Power}");
//    }
//}

//public class Truck : Car
//{
//    public int LoadCapacity { get; set; }
//    public Truck() : base()
//    {
//        Console.WriteLine("Вызван конструктор без параметров для класса Truck");
//    }
//    public Truck(string brand, int cylinders, int power, int loadCapacity) : base(brand, cylinders, power)
//    {
//        LoadCapacity = loadCapacity;
//        Console.WriteLine($"Вызван конструктор с параметрами для класса Truck. Значение LoadCapacity: {LoadCapacity}");
//    }
//    public void SetBrand(string newBrand)
//    {
//        Brand = newBrand;
//        Console.WriteLine($"Установлено новое значение Brand: {Brand}");
//    }
//    public void SetLoadCapacity(int newLoadCapacity)
//    {
//        if (newLoadCapacity < 0)
//            throw new ArgumentException("Грузоподъемность не может быть отрицательной");

//        LoadCapacity = newLoadCapacity;
//        Console.WriteLine($"Установлено новое значение LoadCapacity: {LoadCapacity}");
//    }
//    public new void Display()
//    {
//        base.Display();
//        Console.WriteLine($"Truck: LoadCapacity - {LoadCapacity}");
//    }
//}