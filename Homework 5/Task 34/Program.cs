/*Задача 34: Напишите программу реализующую методы формирования массива, 
заполненного случайными положительными трёхзначными числами, 
и подсчета количества чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

using static System.Console;
Clear();

int[] array = InitArray(10, 100, 1000);

PrintArray(array);
WriteLine(EvenCount(array));



int EvenCount(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
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