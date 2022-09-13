// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}


//void PrintArray(int[] res)
// {
    
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{res[i]} ");
//     }
    
// }

//int[] ModifArray(int[] res)
// {
//     for (int i = 0; i < size; i++)
//     {
//         res[i] *= -1;
//     }
//     return res;
// }

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    if (i != array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.WriteLine($"{array[i]}");
}
