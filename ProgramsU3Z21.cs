// Урок 3. Базовые алгоритмы. Продолжение
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки в плоскости X, Y и Z: ");
int numXA = Convert.ToInt32(Console.ReadLine());
int numYA = Convert.ToInt32(Console.ReadLine());
int numZA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки в плоскости X, Y и Z");
int numXB = Convert.ToInt32(Console.ReadLine());
int numYB = Convert.ToInt32(Console.ReadLine());
int numZB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((numXB-numXA), 2)+ (Math.Pow((numYB-numYA), 2))+Math.Pow((numZB-numZA), 2));
System.Console.WriteLine($"Расстояние между точками = {result}");