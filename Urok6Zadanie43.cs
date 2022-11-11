// Урок 6. Одномерные массивы. Продолжение
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты первого отрезка b1 и k1: ");
double numB1 = Convert.ToDouble(Console.ReadLine());
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первого отрезка b2 и k2: ");
double numB2 = Convert.ToDouble(Console.ReadLine());
double numK2 = Convert.ToDouble(Console.ReadLine());

double resultX = (numB2-numB1)/(numK1-numK2);
double resultY = (numK1*resultX)+numB1;

System.Console.WriteLine($"точка пересечения двух прямых = --{resultX}--,--{resultY}--");