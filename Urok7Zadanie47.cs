// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = SetNumber("m");
int colum = SetNumber("n");
double [,] matrix = GetRandomMatrix(rows, colum, 10, -10);
PrintMatrix(matrix);

double[,] GetRandomMatrix(int rows, int colum, int maxValue, int minValue)
{
    double[,] matrix = new double[rows, colum];
       for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            Random rand = new Random();
            matrix[i,j]=rand.Next(minValue,maxValue)*rand.NextDouble();
        }
    }
    return matrix;
}
int SetNumber(string name)
{
    System.Console.WriteLine($"Enter number {name}");
    int num = int.Parse(Console.ReadLine());
    return num;
}
void PrintMatrix(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f1} ");
        }
        System.Console.WriteLine();
    }
}
PrintMatrix(matrix);