// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using System;

double Exponentiation(double a, int b)
{
    double altA= a;
    for(int i=1;i<b;i++)
    a=a*altA;
    return a;
}

char[] delimiterChar = {' ',',','.','(',')','[',']','/'};
string[] ins = new string[] {"0","0","0","0","0"};  
double baseA=0.0;
int expB = 0;
bool checkNum1 = false;
bool checkNum2 = false;
do
{   // Console.WriteLine("постарался скукожить ввод с клавиатуры");
    Console.WriteLine("Введите число для возведения в степень и степень корректно(например \"6 5\" без кавычек):");
    ins = Console.ReadLine().Split(delimiterChar);
    if (ins.Length <2) continue;
    checkNum1 = double.TryParse(ins[0], out baseA);
    checkNum2 = int.TryParse(ins[1], out expB);
}
while (!checkNum1 || !checkNum2);
Console.WriteLine($"{baseA}, {expB} -> {Exponentiation(baseA,expB)}");