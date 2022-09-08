// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа принимает на вход целое число c кол-вом знаков от 5");
Console.WriteLine("и проверяет, является ли это число палиндромом");
Console.WriteLine();
Console.WriteLine("Введите число для проверки:");
bool checkNum = int.TryParse(Console.ReadLine(), out int num);
int minNumbCharacters = 9999;

while (!checkNum && num>minNumbCharacters)
{
    Console.WriteLine("Введите число для проверки:");
    checkNum = int.TryParse(Console.ReadLine(), out num);
}
int numOperations = num;
int numOperCount = 0;
while(numOperations>0) //посчитаем сколько цифр в числе.
{
    numOperations = numOperations / 10;
    numOperCount++;
    Console.WriteLine($"{numOperations}");
}
Console.WriteLine($"кол-во цифр {numOperCount}");
for (numOperations = 1; numOperations<=numOperCount/2; numOperations++)
{
    Console.Write($"сравниваем {num%Math.Pow(10,numOperations)}   ");
    Console.WriteLine($"с  {num/Convert.ToInt32(Math.Pow(10,numOperCount-1))}");
    if (num%Math.Pow(10,numOperations) == num/Convert.ToInt32(Math.Pow(10,numOperCount-1)))
    {
        Console.WriteLine($"сравниваем {numOperations}");
    }
    else break;
}

if (numOperations == numOperCount/2-1)
{
    Console.WriteLine($"Число {num} палиндром            {numOperations}");
}
else Console.WriteLine($"Число {num} не палиндром     {numOperations}");
