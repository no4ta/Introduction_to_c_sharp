// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length == 3)
{
    Console.WriteLine("Вторая цифра этого числа: " +b[1]);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}