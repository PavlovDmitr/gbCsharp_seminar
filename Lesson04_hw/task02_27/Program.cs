// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


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
int num = 0;
string insStr = "";
string exitWord = "NO";
bool checkInsNum = false;
bool flagExit = false; // пока просматривал код подумал что нагляднее когда флаг имеет состояние соответвующее названию,
                            // если я его назвал "флаг выхода" - то и выходить по нему тогда, когда он true. подумал я)
while(!flagExit) // просто бесконечная программа, есть ли какой то более удобный и правильный выход из такой программы? ну или может более правильное ее оформление?
{
    do
    {
        Console.WriteLine("Введите целое число для получения суммы цифр, или введите NO для выхода:");
        insStr = Console.ReadLine();
        if (insStr==exitWord) {flagExit = true; break;} 
        checkInsNum = int.TryParse(insStr, out num);
    }
    while (!checkInsNum);
    if(!flagExit) Console.WriteLine($"{num} -> {SumOfDigit(num)}");
}