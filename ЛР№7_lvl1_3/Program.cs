class Sportsmen
{
    public string surname;
    public double percent;
}

class Program
{
    static void Main()
    {
        Sportsmen[] sp = new Sportsmen[10];
        for (int i = 0; i < sp.Length; i++) sp[i] = new Sportsmen();
        string[] surname = new string[] { "Райан Гослинг\t", "Владимир Соловьев\t", "Джеймс Хетфилд\t" , "Даймбег Даррел\t", "Дэвид Гилмор\t\t",
            "Роскошный Джордж\t", "Эдвард Каллен Руки-ножницы  ", "Лена Головач\t\t", "Лера Язагит\t\t", "Тони Пуля в зубах\t" };
        double[] percent = new double[] { 98.3, 5.1, 69.7, 32.1, 45.3, 97.5, 0.1, 88.2, 0.3, 44.3 };
        Console.WriteLine("Знаменитости:");
        for (int i = 0; i < sp.Length; i++)
        {
            sp[i].surname = surname[i];
            sp[i].percent = percent[i];
            Console.WriteLine(
                "Имя знаменитости - {0:}\tПроценты запросов - {1}%",
                sp[i].surname, sp[i].percent);
        }
        for (int i = 0; i < sp.Length; i++)
        {
            double amax = sp[i].percent;
            int imax = i;
            for (int j = i + 1; j < sp.Length; j++)
            {
                if (sp[j].percent > amax)
                {
                    amax = sp[j].percent;
                    imax = j;
                }
            }
            Sportsmen temp;
            temp = sp[imax];
            sp[imax] = sp[i];
            sp[i] = temp;
        }
        Console.WriteLine();
        Console.WriteLine("Топ 5 знаменитостей:");
        for (int i = 0; i < sp.Length; i++)
        {
            Console.WriteLine(
               "Имя знаменитости - {0}\tПроценты запросов - {1}%",
               sp[i].surname, sp[i].percent);
        }
    }
}
