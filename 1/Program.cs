using System;
using System.Linq;
using System.Text;


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число число: ");
string x = Console.ReadLine()!;
int lenx = x.Length;
string x_reverse = string.Empty;

for (int i = lenx-1; i>=0; i--)
{
x_reverse +=x[i];
}
if (x_reverse == x)
{
Console.WriteLine("ДА");
}
else Console.WriteLine("НЕТ");


