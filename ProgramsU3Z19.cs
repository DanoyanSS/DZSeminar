// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите проверяемое число :");
string strNumber1 = Console.ReadLine();

int num1 = int.Parse(strNumber1);
int Reverse(int num1, int acc)
{
    while (num1>0)
    {
        acc=acc*10+num1%10; 
        num1 /= 10;
    }
    return acc;
}

if (Reverse(num1, 0)==num1)
{
    Console.WriteLine("Число является полиндромом");
}
else {Console.WriteLine("Число не является полиндромом");}