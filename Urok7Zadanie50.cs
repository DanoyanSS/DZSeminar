// Урок 7. Двумерные массивы
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = SetNumber("m");
int colum = SetNumber("n");
int [,] matrix = GetRandomMatrix(rows, colum, 10, 1);


int[,] GetRandomMatrix(int rows, int colum, int maxValue =100, int minValue = -100)
{
    int[,] matrix = new int[rows, colum];
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=random.Next(minValue, maxValue+1);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int SetNumber(string name)
{
    System.Console.WriteLine($"Enter {name}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

PrintMatrix(matrix);
int searchNumber=SetNumber("Искомое число");
int m=0, n=0;
bool f = false;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (searchNumber == matrix[i, j]) { m = i;n = j;f = true; };
        }
}
                       
    if (f)
        Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
    else
    Console.WriteLine("Число не найдено");