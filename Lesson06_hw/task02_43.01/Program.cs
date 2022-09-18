//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool CheckInsert(List<bool> check)
{
    for (int i = 0; i < check.Count; i++)
    {
        if (check[i] == false) { return false; }
    }
    return true;
}

double[] ConverListToArray(List<double> inslist)
{
    int count = inslist.Count;
    double[] arr = new double[count+1];
    for(int i= 0; i<count; i++)
    {
        arr[i] = Convert.ToDouble( inslist[i] );
    }
    return arr;
}

(bool, double[]) InsertUserDataDouble()
{
    char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
    string[]? insArrayStrings = new string[1];
    double[] arrayDouble = new double[1];
    bool checkParse = false;
    List<double> numberList = new List<double> { };
    List<bool> checkList = new List<bool> { };
    do
    { 
    checkList.Clear();
    string? insStr = Console.ReadLine();
    insArrayStrings = insStr?.Split(delimiterChar);
    //Console.WriteLine(String.Join(", ", insArrayStrings));
    if(insArrayStrings[0].ToLower().Equals("quit") || insArrayStrings[0].ToLower() == "exit") {break; }
    if(insArrayStrings[0].ToLower().Equals("")) 
        {
            Console.WriteLine($"Ошибка ввода, ввод необходимо начинать с числа");
        }
    for (int i = 0; i < insArrayStrings.Length; i++)
    {
        checkParse = double.TryParse(insArrayStrings[i], out double nextNum);
        //Console.WriteLine($"{checkParse} parse");
        checkList.Add(checkParse);
        //Console.WriteLine($"{nextNum} num");
        numberList.Add(nextNum);

    }
    if (!CheckInsert(checkList)) Console.WriteLine($"Произвведите корректный ввод чисел (или quit для выхода)");
    }
    while (!CheckInsert(checkList));
    if (insArrayStrings[0].ToLower() == "quit" || insArrayStrings[0].ToLower() == "exit") return (false, ConverListToArray(numberList));
    else return (true, ConverListToArray(numberList));
}

(double, double) CalcCrossPoint(double[] userArray)
{   //y = k1 * x + b1, y = k2 * x + b2, x = (b1-b2)/(k2 - k1).
    double resultX = 0;
    double resultY = 0;
    resultX = (userArray[0] - userArray[2])/(userArray[3]-userArray[1]);
    resultY = (userArray[1]*resultX+userArray[0]);
    return (resultX, resultY);
}

string descriptionApp =
@"************************************************
* Программа находит точку пересечения двух 
* прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2  *
************************************************";
string welcomText = @"Введите значения b1, k1, b2, k2
quit - для выхода из программы.";

//Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
Console.WriteLine(welcomText);
//Console.WriteLine("Введите любое кол-во чисел через пробел,");

do
{
    var tuple = InsertUserDataDouble();
    var result2 = CalcCrossPoint(tuple.Item2);
    //Console.WriteLine(tuple.Item1);
    if (tuple.Item1 == false ) {  /*Console.WriteLine(tuple.Item1);*/ break;}
    if (tuple.Item1 == true) 
    {
        Console.Write("Результат вычислений: ");
        Console.WriteLine($"[{String.Join(", ", tuple.Item2)}] -> ({result2.Item1}, {result2.Item2})");
        Console.WriteLine("Введите следующую группу чисел(или quit для выхода): ");
    }
}
while (true);