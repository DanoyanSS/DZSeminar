// Урок 4. Функции
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число (N) для получения суммы цифр этого числа: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

int sumOfDigits(int numFirst)
{
    int result=0;
    while (numFirst>0)
    {
        result += numFirst % 10;
        numFirst = numFirst / 10;
    }
    return result;
}
int result = sumOfDigits(numFirst);

System.Console.Write($"Сумма цифр числа {numFirst} = {result}");