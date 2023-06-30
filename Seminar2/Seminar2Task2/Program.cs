// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число, в котором больше 2-х знаков: ");
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a);
if (b.Length > 2)
{
    Console.WriteLine("Третья цифра: " +b[2]);
}
else if (b.Length <= 2)
{
    Console.WriteLine("Вы ввели не подходящее под условие число!");
}