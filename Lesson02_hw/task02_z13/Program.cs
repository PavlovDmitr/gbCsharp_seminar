// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int constDelitel = 10; // делитель для числа, чтобы цифры убирать)))
Console.WriteLine("Введите число");
int numberFirst = int.Parse(Console.ReadLine());
int numberDouble = numberFirst; //создаеи дубликат для проведения расчетных операций
if (numberFirst > 99)  //нам же нужны только числа с 3 и большим кол-вом символов
{
    double count = 0;
    while (numberDouble > 0)
    {
        count = count + 1;
        numberDouble = numberDouble / 10;
    }
    count = count - 2; 
    numberDouble = numberFirst;
    for (int iter = 1; iter < count; iter++)
    {
        numberDouble = numberDouble / constDelitel;
    }
    numberDouble = numberDouble % constDelitel;
    Console.WriteLine($"{numberFirst} -> третья цифра {numberDouble}");
}
else Console.WriteLine($"{numberFirst} -> третьей цифры нет");
