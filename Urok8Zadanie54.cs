// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
System.Console.WriteLine();

void SortMatrixInString(int [,] matrix){
for (int j = 0; j < matrix.GetLength(0); j++)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    for (int k = 0; k < matrix.GetLength(1); k++)
{
    
        if (matrix[i, j] <= matrix[i, k]) continue;
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
}

}
for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
}
SortMatrixInString(matrix);