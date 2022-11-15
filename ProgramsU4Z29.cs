// Урок 4. Функции
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int elementCount = int.Parse(Console.ReadLine());
Console.Write("Введите массив: ");
int [] array= new int[elementCount];
for (int i = 0; i < array.Length; i++)
{
    array[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.ReadLine();