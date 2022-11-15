// Урок 8. Двумерные массивы. Продолжение
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows1 = SetNumber("m");
int colum1 = SetNumber("n");
int [,] matrix1 = GetRandomMatrix(rows1, colum1, 10, 1);
PrintMatrix(matrix1);
System.Console.WriteLine();

int rows2 = SetNumber("m");
int colum2 = SetNumber("n");
int [,] matrix2 = GetRandomMatrix(rows2, colum2, 10, 1);
PrintMatrix(matrix2);
System.Console.WriteLine();
int [,] matrix3 = MatrixMultiplication(matrix1, matrix2);
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2){
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
            return matrix3;
}
PrintMatrix(matrix3);
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