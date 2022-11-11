// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива: ");
int elementCount = int.Parse(Console.ReadLine());
Console.Write("Введите массив: ");
System.Console.WriteLine();
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
int sumArr=0;
for (int i = 0; i < array.Length; i++){
    if(array[i]>0){
        sumArr++;
    }
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Пользователь ввел <<{sumArr}>> числа больше 0");
Console.ReadLine();