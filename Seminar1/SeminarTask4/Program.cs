// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int number = 2;
if (number > 1)
{
    while (number <= a)
    {
        Console.Write(number + " ");
        number = number + 2;
    }
}