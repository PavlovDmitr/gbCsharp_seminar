// See https://aka.ms/new-console-template for more information
string[] str = {"Ненужный элемент массива, чтобы не вычитать единичку:)", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите число-номер дня недели: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Название дня недели с номером {num} - {str[num]}");