// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] ConvertStrToArray(string insStr)
{
    char[] delimiterChar = {' ',',','.','(',')','[',']','/'};
    string[] allPointPositionStr = insStr.Split(delimiterChar);
    double[] allPointPositionDigit = new double[] {0,0,0,0,0,0,0};
    int pointNum = 1;
    allPointPositionDigit[0] = 1;
    bool check = false;
    foreach (string point in allPointPositionStr)
    {
        check = double.TryParse(point, out allPointPositionDigit[pointNum]);
        if (!check) break;
        pointNum++;
                
    }
    if (check) return allPointPositionDigit;
    else  {allPointPositionDigit[0] = 0; return allPointPositionDigit;}
}

double[] dblArray = new double[] {0,0,0,0,0,0,0};

while ( dblArray[0] != 1) 
{
    Console.WriteLine("Введите координаты 2х точек как в примере - 3,6,8 2,1,7 :");
    dblArray = ConvertStrToArray(Console.ReadLine());
}
double distance3d = 0.0;
//for (int i= 0; i<7;i++) Console.WriteLine($" {dblArray[i] }");
distance3d = Math.Sqrt(Math.Pow(dblArray[1]-dblArray[4], 2)
                       +Math.Pow(dblArray[2]-dblArray[5], 2)
                       +Math.Pow(dblArray[3]-dblArray[6], 2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance3d,2)}");

