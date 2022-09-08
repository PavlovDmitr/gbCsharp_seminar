// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

double ReturnDigitFromNumber(double fullNumber, int number)
{
    int result = 0;
    result = Convert.ToInt32(fullNumber%Math.Pow(10, number));
    //Console.WriteLine( result);
    result = result/Convert.ToInt32(Math.Pow(10, number-1));
    return result;
}

int ReturnCountDigit(int num)
{
    int numCount = 0;
    while(num>0) //посчитаем сколько цифр в числе.
    {
        num = num / 10;
        numCount++;
        // Console.WriteLine($"{numOperations}");
    }
    Console.WriteLine($"кол-во цифр {numCount}");
    return numCount;
}

Console.WriteLine("Программа принимает на вход целое число c кол-вом знаков от 5");
Console.WriteLine("и проверяет, является ли это число палиндромом");
Console.WriteLine();

int minNumbCharacters = 9999;

Console.WriteLine("Введите число для проверки:");
bool checkNum = int.TryParse(Console.ReadLine(), out int num);
while (!checkNum || num<minNumbCharacters)
{
    Console.WriteLine("Введите правильное число для проверки:");
    checkNum = int.TryParse(Console.ReadLine(), out num);
}
int numOperations = num;
int numOperCount = ReturnCountDigit(num);

for (numOperations = 1; numOperations<=numOperCount/2; numOperations++)
{
    
    if ((ReturnDigitFromNumber(num, numOperations)) != ReturnDigitFromNumber(num, numOperCount-numOperations+1))
    {
        break;
    }
    else 
    {   
        Console.WriteLine($"сравниваем цифру №{numOperations} с цифрой №{numOperCount-numOperations+1}");
        Console.Write($"                 { ReturnDigitFromNumber(num, numOperations) }   ");
        Console.WriteLine($"  ?=    {ReturnDigitFromNumber(num, numOperCount-numOperations+1)}");

    }
}
if (numOperations == numOperCount/2+1)
{
    Console.WriteLine($"Число {num} палиндром ");
}
else Console.WriteLine($"Число {num} не палиндром");

// вот до сюда я делал несколько часов (((

Console.WriteLine("Введите число для проверки с использованием типа string:");
string? numberStr = Console.ReadLine();
int numStrLen = numberStr.Length;
int strCount = 0;
for (int i= 0; i<numStrLen/2; i++)
{
   
    if (numberStr[i] == numberStr[numStrLen-1-i])
    {
        strCount++;
    }
    else break;
}
if (strCount == numStrLen/2)
{
    Console.WriteLine($"Число {numberStr} палиндром");
}
else Console.WriteLine($"Число {numberStr} не палиндром");

//  а до сюда минут 30 отвлекаясь