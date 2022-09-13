// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int count = 0;
Console.WriteLine("Введите число для проверки на наличие в массиве: ");
int n = int.Parse(Console.ReadLine());

int[] array = GetArray(5, 1, 10);
Console.Write("массив [");
for (int i = 0; i < array.Length; i++)
{
    if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); // \r\n
    if (array[i] == n)
    {
        count++;
    }
}
Console.Write("] ");
Console.Write((count == 0 ? $"-> нет " : $"-> да, {count} раз(а)"));
//Console.Write(((count==2 || count==3 || count==4) ? "раза" : "раз"));

