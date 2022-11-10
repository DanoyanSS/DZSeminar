// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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


int[] array = GetRandomArray(3, 100, 999);
PrintArray(array);
int sumOfEven = 0;
for(int i = 0; i < array.Length; i++)
{
        if (array[i]%2==0){
        sumOfEven++;
    }
}

System.Console.WriteLine("четных чисел в массиве=" + sumOfEven);