// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArrayMetod (int min, int max, int num)
{
    int[] result = new int[num];
    for(int i=0;i<num;i++)
    result[i] = new Random().Next(min, max+1);
    return result;
}