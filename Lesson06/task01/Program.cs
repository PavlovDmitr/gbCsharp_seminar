// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] resPA)
{
    int size = resPA.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(i != size-1 ? $"{resPA[i]}, ": $"{resPA[i]}");
    }
    Console.Write("]");
}

int[] GetConvertArray(int[] resGCEN)
{
    int count = 0;
    for (int i = 0; i < resGCEN.Length /2 ; i++)
        (resGCEN[i], resGCEN[resGCEN.Length-i-1]) = (resGCEN[resGCEN.Length-i-1], resGCEN[i]);
            count++;
    return resGCEN;
}

string descriptionApp = @"Программа создает массив заданой длины 
случайными числами и выводит прямую и перевернутую версию";
int minValueArr = 0, maxValueArr = 10;

Console.Clear();
Console.WriteLine(descriptionApp);
Console.WriteLine();
char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };
string[] arrayStrings = new string[2];
int[] arrayInt = new int[1];
int arrayLenght = 0;
bool checkParse = false;


do
{
    Console.WriteLine("Введите размер массива:");
    arrayStrings = Console.ReadLine().Split(delimiterChar);
    if (arrayStrings.Length < 1) {continue;};
    checkParse = int.TryParse(arrayStrings[0], out arrayLenght);
}
while (!checkParse);
arrayInt = GetArray(arrayLenght, minValueArr, maxValueArr);
Console.WriteLine($"Массив размерности {arrayLenght} и результат:");
PrintArray(arrayInt);
PrintArray(GetConvertArray(arrayInt));


Console.Clear();
int [] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array));

int [] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ",reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ",array));

void ReversArray1(int[] inArray)
{
    for(int i=0; i<inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i -1];
        inArray[inArray.Length-i -1] = k;
    }
}

int [] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i=0;i<inArray.Length;i++ )
    {
        result[i] = inArray[inArray.Length - 1 -i];
    }
    return result;
}
