/*Задача 36: Напишите программу реализующую методы формирования массива, 
заполненного случайными числами и подсчета суммы элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0*/

using static System.Console;
Clear();

int[] array = InitArray(10, -100, 100);

PrintArray(array);
WriteLine(SumOddIndexNumber(array));



int SumOddIndexNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

int[] InitArray(int size, int start, int end)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(start, end);
    return arr;
}

void PrintArray(int[] arr)
{
    Write("[");
    foreach (int i in arr) Write($"{i},");
    WriteLine($"{arr[arr.Length - 1]}]");
}