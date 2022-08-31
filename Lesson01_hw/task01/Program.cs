//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
double[] num = new double[2];
bool[] check = {false, false};
Console.WriteLine("Введите 2 числа, определим какое меньше, а какое больше!");
while (!(check[0] && check[1]))
{
    string[] str = Console.ReadLine().Split(' ');
    for (int i = 0; i < 2; i++){
    check[i] = double.TryParse(str[i], out num[i]);
    }
        if (check[0] && check[1])
    {
        if (num[0]<num[1])
        {
            Console.WriteLine($"{num[1]} больше чем {num[0]}");
        }
        else Console.WriteLine($"{num[0]} больше чем {num[1]}");
    }
    else Console.WriteLine($"Введите нормальных 2 числа - для дробных чисел разделитель целой и дробной части в Windows запятая!");
}