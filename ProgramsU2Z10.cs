//Урок 2. Базовые алгоритмы
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число :");
string strNumber1 = Console.ReadLine();

int num1 = int.Parse(strNumber1);

Console.WriteLine(num1>99 ? num1.ToString()[1] : "Число не является трехзначным");
Console.ReadKey(true);