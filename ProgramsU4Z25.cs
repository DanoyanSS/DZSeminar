// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число (N) для возведения в натуральную степень: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (C) для возведения числа (N) в степень (С): ");
int numSecond = Convert.ToInt32(Console.ReadLine());

int result=numFirst;

for (int i = 1; i < numSecond; i++)
{
    result=result*numFirst;
}
System.Console.Write($"Число {numFirst} возведенное в степень {numSecond} = {result}");