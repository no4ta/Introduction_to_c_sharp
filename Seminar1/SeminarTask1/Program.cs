﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число больше второго");
}
else if (a < b)
{
    Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Первое число равно второму числу");
}