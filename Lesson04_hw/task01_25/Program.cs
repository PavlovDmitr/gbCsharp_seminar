// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exponentiation(double a, int b)
{
    double altA= a;
    for(int i=1;i<b;i++)
    a=a*altA;
    return a;
}

char[] delimiterChar = {' ',',','.','(',')','[',']','/'};
string[] ins = new string[5];  
bool checkNum1 = true;
bool checkNum2 = true;
double baseA=0.0;
int expB = 0;
do
{   // Console.WriteLine("постарался скукожить ввод с клавиатуры");
    Console.WriteLine("Введите число для возведения в степень и степень корректно(например \"6 5\" без кавычек):");
    ins = Console.ReadLine().Split(delimiterChar); 
    checkNum1 = double.TryParse(ins[0], out baseA);
    checkNum2 = int.TryParse(ins[1], out expB);
}
while (!checkNum1 || !checkNum2);
Console.WriteLine($"{baseA}, {expB} -> {Exponentiation(baseA,expB)}");