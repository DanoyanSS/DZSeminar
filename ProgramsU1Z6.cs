//Урок 1. Знакомство с языком программирования С#
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите проверяемое число :");
string strNumber1 = Console.ReadLine();

int num1 = Convert.ToInt32(strNumber1);
int result1= num1%2;

if (result1==0)
{
    System.Console.WriteLine($"Число {num1} является четным");
}
else
{
    System.Console.WriteLine($"Число {num1} не является четным");
}