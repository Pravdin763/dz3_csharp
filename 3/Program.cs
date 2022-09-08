using System;
using System.Linq;
using System.Text;

// Принимает число "н" и выдает таблицу кубов из чисел от 1 до "н"

Console.WriteLine("Введите целое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Кубы чисел от 1 до {x}:");
for (int i=1; i<=x; i++)
{
Console.Write($"{i*i*i}, ");
}