//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Enter number1 :");
string strNumber1 = Console.ReadLine();
System.Console.WriteLine("Enter number2 :");
string strNumber2 = Console.ReadLine();

int num1 = Convert.ToInt32(strNumber1);
int num2 = Convert.ToInt32(strNumber2);

if (num1>num2)
{
    Console.WriteLine($"Большее число= {num1}");
    Console.WriteLine($"Меньшее число= {num2}");
}
else {
    Console.WriteLine($"Большее число= {num2}");
    Console.WriteLine($"Меньшее число= {num1}");
}
