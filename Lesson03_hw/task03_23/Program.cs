// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для получения таблицы кубов:");
bool checkNum = int.TryParse(Console.ReadLine(), out int num);

while (!checkNum)
{
    Console.WriteLine("Введите число для проверки:");
    checkNum = int.TryParse(Console.ReadLine(), out num);
}
Console.Write($"{num} -->");
for (int i = 1; i<=num; i++)
if (i != num) Console.Write($" {Math.Pow(i, 3)}, ");
else Console.Write($" {Math.Pow(i, 3)} ");
Console.WriteLine();