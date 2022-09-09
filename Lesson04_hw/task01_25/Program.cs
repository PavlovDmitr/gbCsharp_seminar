// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exponentiation(double a, int b)
{
    double altA= a;
    for(int i=1;i<b;i++)
    a=a*altA;
    //Console.WriteLine($"согласно условию задания надо цикл рузультат вот - {a}");
    return a;
}

char[] delimiterChar = {' ',',','.','(',')','[',']','/'};
Console.WriteLine("Введите число для возведения в степень и степень через пробел:");
string[] ins = Console.ReadLine().Split(delimiterChar);  
bool checkNum1 = double.TryParse(ins[0], out double baseA);
bool checkNum2 = int.TryParse(ins[1], out int expB);
while (!checkNum1 || !checkNum2)
{
    Console.WriteLine("Введите число для возведения в степень и степень корректно(например \"6 5\" без кавычек):");
    ins = Console.ReadLine().Split(delimiterChar); 
    checkNum1 = double.TryParse(ins[0], out baseA);
    checkNum2 = int.TryParse(ins[1], out expB);
}
Console.WriteLine($"{baseA}, {expB} -> {Exponentiation(baseA,expB)}");