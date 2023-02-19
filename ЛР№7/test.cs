using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем список участниц кросса
        List<Runner> runners = new List<Runner>();

        // Вводим данные об участницах кросса
        runners.Add(new Runner("Иванова", "Группа 1", "Петров", 520));
        runners.Add(new Runner("Петрова", "Группа 2", "Иванов", 480));
        runners.Add(new Runner("Сидорова", "Группа 1", "Петров", 480));
        runners.Add(new Runner("Кузнецова", "Группа 2", "Иванов", 510));
        runners.Add(new Runner("Николаева", "Группа 1", "Петров", 490));

        // Сортируем список по результатам
        runners.Sort();

        // Выводим таблицу результатов
        Console.WriteLine("Фамилия\t\tГруппа\t\tПреподаватель\tРезультат\tНорматив");
        int count = 0;
        foreach (Runner runner in runners)
        {
            Console.Write(runner.LastName + "\t\t");
            Console.Write(runner.Group + "\t\t");
            Console.Write(runner.Teacher + "\t\t");
            Console.Write(runner.Result + "\t\t");
            Console.WriteLine(runner.IsNorm() ? "Выполнен" : "Не выполнен");
            if (runner.IsNorm()) count++;
        }

        // Выводим количество участниц, выполнивших норматив
        Console.WriteLine("Количество участниц, выполнивших норматив: " + count);
    }
}

class Runner : IComparable<Runner>
{
    public string LastName { get; set; }
    public string Group { get; set; }
    public string Teacher { get; set; }
    public int Result { get; set; }

    public Runner(string lastName, string group, string teacher, int result)
    {
        LastName = lastName;
        Group = group;
        Teacher = teacher;
        Result = result;
    }

    public bool IsNorm()
    {
        return Result <= 500;
    }

    public int CompareTo(Runner other)
    {
        return Result.CompareTo(other.Result);
    }
}
