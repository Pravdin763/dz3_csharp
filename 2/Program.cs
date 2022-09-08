using System;
using System.Linq;
using System.Text;

// найти расстояние между 2 точек в 3d пространстве

Console.WriteLine("Введите координату Х первой точки");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x второй точки");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х второй точки");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки");
int z2 = int.Parse(Console.ReadLine()!);

double distanse = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
Console.WriteLine($" Расстояние между точками = {distanse:F2}");
