using System;

while (true)
{
    Console.WriteLine("Выбери действие которое хочешь выполнить:");
    Console.WriteLine("1.Игра угадай число");
    Console.WriteLine("2.Таблица умножения");
    Console.WriteLine("3.Вывод делителя числа");
    Console.WriteLine("4.Выйти из программы");
    Console.WriteLine("Вы выбрали число: ");
    string a = Console.ReadLine();
    if (a == "1")
    {
        Console.WriteLine("Здесь тебе надо угадать число от 1 до 100(всё очень просто)");
        Console.WriteLine("Компьютер загадал число попробуй его отгадать");
        Random rnd = new Random();
        int k = rnd.Next(1, 100);
        int count = 0;
        string str;

        do
        {
            Console.Write("Ваш вариант: ");
            str = Console.ReadLine();

            if (int.Parse(str) < k)
                Console.WriteLine("Задуманное число больше");
            if (int.Parse(str) > k)
                Console.WriteLine("Задуманное число меньше");

            count++;
        }
        while (int.Parse(str) != k);
        Console.WriteLine("Вы угалдали с {0} попытки", count);
        Console.ReadLine();
    }
    if (a == "2")
    {
        Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
        Console.Write("--------------------------------------------------------------------------");
        Console.WriteLine();
        for (int i = 1; i < 10; i++)
        {
            Console.Write(i + "   |  ");
            for (int j = 1; j < 10; j++)
            {
                Console.Write("\t" + i * j);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
    if (a == "3")
    {
        Deliteli();
    }
    if (a == "4")

    {
        Environment.Exit(0);
    }

}

static void Deliteli()
{
    string res;
    int intA1;
    Console.Write("Программа выведет все числа, на которое ваше число делиться без остатка. \r\n \r\nВведите число:");
    intA1 = Convert.ToInt32(Console.ReadLine());
    res = "";
    for (int i = 1; i <= intA1; i++)
    {
        if (intA1 % i == 0)
        { res += i + " "; }
    }
    Console.WriteLine("Все целые числа, на которое заданное число делиться без остатка: ");
    Console.Write(res);
    Console.ReadLine();
}