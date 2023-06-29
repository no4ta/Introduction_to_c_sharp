// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int remDiv = a % 2;
if (remDiv == 0)
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
