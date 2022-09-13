// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resGA = new int[size];
    for (int i = 0; i < size; i++)
    {
        resGA[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resGA;
}


int[] GetProduct(int[] resGP)
{
    int lenArray = resGP.Length;
    int lenPartArray = 0;
    if (lenArray % 2 == 0) lenPartArray = lenArray / 2;
    else lenPartArray = lenArray / 2 + 1;
    int[] arrayProduct = new int[lenPartArray];
    for (int i = 0; i < lenPartArray; i++)
    {
        if (i == lenPartArray-1 && lenArray % 2 != 0 ) arrayProduct[i] = resGP[i];
        else arrayProduct[i] = resGP[i] * resGP[lenArray - i - 1];
    }
    return arrayProduct;
}

void PrintArray(int[] resPA)
{
    int size = resPA.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{resPA[i]} ");
    }
    Console.WriteLine();
}

int[] array = GetArray(6, -10, 10);
PrintArray(array);
int[] arrayProduct = GetProduct(array);
PrintArray(arrayProduct);
