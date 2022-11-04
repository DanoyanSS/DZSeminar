// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите проверяемое число :");
string strNumber1 = Console.ReadLine();

int num1 = int.Parse(strNumber1);

Console.WriteLine(num1>99 ? num1.ToString()[2] : "Число не является трехзначным");
Console.ReadKey(true);