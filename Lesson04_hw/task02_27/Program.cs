// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string exitWord = "NO";
bool flag = true;
int SumOfDigit(int numb)

{

    int result = 0;
    while(numb>0)
    {
        result = result + numb%10;
        numb = numb/10;
    }

    return result;
}

while(flag)
{
    Console.WriteLine("Введите целое число для получения суммы цифр или введите NO для выхода:");
    string insStr = Console.ReadLine();
    if (insStr==exitWord) {flag = false; break;}
    bool checkNum = int.TryParse(insStr, out int num);
    
    while (!checkNum)
    {
        Console.WriteLine("Введите целое число для получения суммы цифр, но теперь правильно, или введите NO для выхода:");
        insStr = Console.ReadLine();
        if (insStr==exitWord) {flag = false; break;}
        checkNum = int.TryParse(insStr, out num);
    }

    if(flag) Console.WriteLine($"{num} -> {SumOfDigit(num)}");
}