// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int saturdayNum = 6;
int sundayNum = 7;

Console.WriteLine("Введите число - номер дня недели:");
int number = int.Parse(Console.ReadLine());
if (number == saturdayNum || number == sundayNum) 
Console.WriteLine($"День недели с номером {number}  - выходной");
else 
Console.WriteLine($"День недели с номером {number}  - НЕ выходной");