// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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
int[] array = GetArray(123, -99, 99);
//array[2] = 123;
Console.Write("массив [");
for (int i = 0; i < array.Length; i++)
{
    if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); // \r\n
    if (array[i] >9 && array[i]<100)
    {
        count++;
    }
}
Console.WriteLine("] ");
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] -> {count} ");
//Console.Write(((count==2 || count==3 || count==4) ? "раза" : "раз"));