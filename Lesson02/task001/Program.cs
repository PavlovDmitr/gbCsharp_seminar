// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
//for (int i=1; i<=10; i++){
int num = new Random().Next(100, 1000);
int a1 = num /10;
int a2 = num % 10;
if (a1>a2)
{
    Console.WriteLine($"Максимальная цифра в числе {num} -> {a1}");
}
else
{
    Console.WriteLine($"Максимальная цифра в числе {num} -> {a2}");
}
//}