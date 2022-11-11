// Урок 7. Двумерные массивы
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.Write("Среднее арифметическое каждого столбца:");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)} ");
}
