// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число число: ");
int a = int.Parse(Console.ReadLine());
string b = Convert.ToString(a);

void CheckNum(string a){
  if (b[0]==b[4] || b[1]==b[3]){
    Console.WriteLine($"Введённое вами число: {b} - является палиндромом");
  }
  else Console.WriteLine($"Введённое вами число: {b} - не является палиндромом");
}

if (b.Length == 5){
  CheckNum(b);
}
else Console.WriteLine("Внимательно прочитайте условие и введите правильное число");