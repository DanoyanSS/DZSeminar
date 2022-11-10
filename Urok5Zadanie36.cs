// Урок 5. Функции и одномерные массивы
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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


int[] array = GetRandomArray(4, 100, 999);
PrintArray(array);
int sumOfNonElevent = 0;
for(int i = 0; i < array.Length; i++)
{
        if (i%2!=0) sumOfNonElevent+=array[i];
}

System.Console.WriteLine("cумма не четных элементов в массиве=" + sumOfNonElevent);