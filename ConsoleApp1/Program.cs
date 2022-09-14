//Скрипников варинт 17

Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
double N = 3 + Math.Pow(y, 2) + Math.Sqrt(y + 1);
Console.WriteLine($"N = {N:F2}");
