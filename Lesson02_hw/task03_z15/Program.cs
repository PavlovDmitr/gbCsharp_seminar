// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int saturdayNum = 6;
int sundayNum = 7;
bool numOk = true;

Console.WriteLine("Введите число - номер дня недели:");
while (numOk)
{
int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <=7) 
{
    if (number == saturdayNum || number == sundayNum) 
    {Console.WriteLine($"День недели с номером {number}  - выходной"); numOk =false;}
    else 
    {Console.WriteLine($"День недели с номером {number}  - НЕ выходной"); numOk =false;}
}
else {Console.WriteLine("Номер за пределами нумерации дней недели, попробуйте еще раз:");}
}