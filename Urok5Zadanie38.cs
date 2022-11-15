// Урок 5. Функции и одномерные массивы
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]+" ");
        //System.Console.Write($"{arr[i]} ");
    }
}

int[] GetRandomArray(int size, int begin, int last)
{
    int [] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i]= random.Next(begin, last+1);
    }
    return arr;
}


int[] array = GetRandomArray(4, 1, 100);
PrintArray(array);
int maxValue = int.MinValue;
int minValue = int.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]>maxValue) maxValue=array[i];
    if(array[i]<minValue) minValue=array[i];
} 
System.Console.WriteLine("Минимальное число в массиве=" + minValue+ "\t" + "Максимальное число в массиве=" + maxValue);
System.Console.WriteLine($"Разница между минимальным и максимальным элементами= {maxValue-minValue}");