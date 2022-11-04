// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите проверяемый день недели - выходной он или нет :");
string strNumber1 = (Console.ReadLine());

int num1 = Convert.ToInt32(strNumber1);
if (num1 >=6 && num1 <= 7)
{
   Console.WriteLine("Выходной!");
}
else 
{
    Console.WriteLine ("Нет!");
}