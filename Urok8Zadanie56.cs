// Урок 8. Двумерные массивы. Продолжение
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void SumOfLines(int [,] matrix)
{
    
    int[] res1 = new int[rows];
    int sum= 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
       
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    
    Console.WriteLine($"{sum} ");   
    res1[i]=sum;
    sum=0;    
}
int min = 0;    
            for (int j = 1; j < rows; j++)
            {
                if (res1[j] < res1[min])   //если есть строка с суммой меньше текущей, то пишем в min её индекс
                    min=j;
            }
            Console.WriteLine($"Индекс строки с минимальной суммой элементов: {min}");            
}
SumOfLines(matrix);