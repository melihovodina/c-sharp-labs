﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int a = 0;
NOTE[] mas = new NOTE[10];
menu();
void menu()
{
    Console.Clear();
    Console.WriteLine("NOTES");
    Console.WriteLine("1. Посмотреть все заметки");
    Console.WriteLine("2. Найти заметку");
    Console.WriteLine("3. Добавить заметку");
    Console.WriteLine("4. Выход");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            check(1);
            break;
        case 2:
            check(2);
            break;
        case 3:
            create();
            break;
        case 4:
            System.Environment.Exit(0);
            break;
    }
}
void create()
{
    Console.Clear();
    mas[a] = new NOTE();
    Console.WriteLine("Введите дату: ДД ММ ГГГГ");
    string str = Console.ReadLine();
    string[] arr = str.Split(' ');
    int[] date = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        date[i] = Convert.ToInt32(arr[i]);
    }
    Console.Write("Тема: ");
    string info = Console.ReadLine();
    int x = a + 1;
    mas[a].set(info, date, x);
    Console.Clear();
    Console.WriteLine("Заметка успешно создана");
    a++;
    Console.WriteLine();
    Console.WriteLine("4. Назад");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 4)
        menu();
    else
        System.Environment.Exit(0);
}
void search()
{
    Console.Clear();
    Console.WriteLine("1. Поиск по номеру заметки");
    Console.WriteLine("2. Поиск по дате заметки");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Clear();
            Console.Write("Введите номер заметки: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                if(mas[i].searchByNum(x) == true)
                    mas[i].print();
            }
            Console.WriteLine(); Console.WriteLine("4. Назад");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 4)
                menu();
            else
                System.Environment.Exit(0);
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Введите дату: ДД ММ ГГГГ");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            int[] date = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                date[i] = Convert.ToInt32(arr[i]);
            }
            DateTime search = new DateTime(date[2], date[1], date[0]);
            for (int i = 0; i < a; i++)
            {
                if (mas[i].searchByDate(search) == true)
                    mas[i].print();
            }
            Console.WriteLine(); Console.WriteLine("4. Назад");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            if (choice3 == 4)
                menu();
            else
                System.Environment.Exit(0);
            break;
    }
}
void show()
{
    Console.Clear();
    for (int i = 0; i < a; i++)
    {
        mas[i].print();
    }
    Console.WriteLine();
    Console.WriteLine("4. Назад");
    int choice2 = Convert.ToInt32(Console.ReadLine());
    if (choice2 == 4)
        menu();
    else
        System.Environment.Exit(0);
}
void check(int x)
{
    if (a == 0)
    {
        Console.Clear();
        Console.WriteLine("У вас нету заметок");
        Console.WriteLine("4. Назад");
        int choice2 = Convert.ToInt32(Console.ReadLine());
        if (choice2 == 4)
            menu();
        else
            System.Environment.Exit(0);
    }
    else
    {
        switch(x)
        {
            case 1: show(); break;
            case 2: search(); break;
        }
    }
}
class NOTE
{
    private int num = 0;
    private DateTime datetime;
    private string dateonly;
    private string info;
    public void set(string str, int[] arr, int x)
    {
        datetime = new DateTime(arr[2], arr[1], arr[0]);
        dateonly = datetime.ToShortDateString();
        info = str;
        num = x;
    }
    public void print()
    {
        Console.WriteLine($"{num}. {dateonly}");
        Console.WriteLine(info);
    }
    public bool searchByNum(int x)
    {
        if (x == num)
            return true;
        else return false;
    }
    public bool searchByDate(DateTime x)
    {
        if (x.Day == datetime.Day && x.Month == datetime.Month && x.Year == datetime.Year)
            return true;
        else return false;
    }
}