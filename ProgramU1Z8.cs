//Урок 1. Знакомство с языком программирования С#
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите длинну массива проверяемых чисел на четность :");
string strNumber1 = Console.ReadLine();

int num1 = int.Parse(strNumber1);

for (int i = 1; i <= num1; i++)
{
    if (i%2==0)
    {
        Console.Write(i + ", ");
    }
}
Console.ReadKey();