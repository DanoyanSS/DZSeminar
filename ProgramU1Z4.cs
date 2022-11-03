//Урок 1. Знакомство с языком программирования С#
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Enter number1 :");
string strNumber1 = Console.ReadLine();
System.Console.WriteLine("Enter number2 :");
string strNumber2 = Console.ReadLine();
System.Console.WriteLine("Enter number3 :");
string strNumber3 = Console.ReadLine();

int num1 = Convert.ToInt32(strNumber1);
int num2 = Convert.ToInt32(strNumber2);
int num3 = Convert.ToInt32(strNumber2);
int maxNum=0;

if (num1>maxNum) 
    {
    maxNum=num1;
    }
if (num2>maxNum) 
    {
    maxNum=num2;
    }
if (num3>maxNum)
    {
    maxNum=num3;
    }
System.Console.WriteLine($"Максимальное из чисел = {maxNum}");