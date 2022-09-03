// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число Один");
int numb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число Два");
int numb2 = int.Parse(Console.ReadLine());

if (numb1%numb2 == 0)
{
    Console.WriteLine($"Число {numb2} кратно числу {numb1}");
}
else if (numb2%numb1 == 0)
{
    Console.WriteLine($"Число {numb1} кратно числу {numb2}");
}
else 
{
    Console.WriteLine($"Число {numb1} не кратно числу {numb2}");
}
