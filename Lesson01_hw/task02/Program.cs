// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


bool CheckInsert(List<bool> check)
{

for (int i = 0; i < check.Count; i++)
{
    if (check[i] == false) {return false;}
}
return true;
}

double maxInList(List<double> num)
{
    double max = num[0];
        for (int j =0; j<num.Count; j++)
        {
            if (num[j]>max)
            {
                max = num[j];
            }
        }
        return max;
}

List<double> num =new List<double> {};
List<bool> check = new List<bool> {};
Console.WriteLine("Введите любое кол-во чисел через пробел, и порешаем задачки");

do
{
    string? insStr = Console.ReadLine();
    string[]? arrStr = insStr?.Split(' ');
    for (int i = 0; i < arrStr?.Length; i++)
    {
        check.Add(double.TryParse(arrStr[i], out double nextNum));
        //Console.WriteLine(check[i]);
        num.Add(nextNum);
        Console.WriteLine($"Ввод окончен...{nextNum}");
    }
    Console.WriteLine("Пробуем разобрать что написано...");
    if (CheckInsert(check))
    {   
        double max = maxInList(num);                                    //Решение задачи 4
        Console.Write($"Максимально число равно {max} ");

        if (max % 2 == 0) Console.WriteLine($"и это число - четное");   //Решение задачи 6
        else Console.WriteLine($"и это число - НЕ четное");

        Console.WriteLine($"Четные числа до {max}: ");
        for (int x = 2; x<max; x = x+2) Console.Write($"{x}, ");            //Решение задачи 8, строго ДО
        if (max % 2 == 0) Console.WriteLine($" .....написано ДО, но если вдруг включительно, то:");
        for (int x = 2; x<=max; x = x+2) Console.Write($"{x}, ");           //Решение задачи 8, не строго)

    }
    else 
    {
        Console.WriteLine($"Введите нормальные числа - для дробных чисел разделитель целой и дробной части в Windows запятая!");
    }
}while (!(CheckInsert(check)));