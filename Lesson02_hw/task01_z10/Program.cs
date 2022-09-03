// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int delitel = 10;
int number = 0;
Console.WriteLine("Введите трехзначное число:");
number= int.Parse(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа {number}  - {(number/delitel)%delitel}");