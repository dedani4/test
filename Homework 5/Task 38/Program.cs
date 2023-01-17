/*Задача 38: Напишите программу реализующую методы формирования массива, 
заполненного случайными вещественными числами 
и вычисления разницы между максимальным и минимальным элементов массива.
[3,3 7,1 22,5 2,2 78,2] -> 76*/


using static System.Console;
Clear();

double[] array = InitArray(10, -15.6, 25.9);

PrintArray(array);
WriteLine(MaxMinDif(array));



double MaxMinDif(double[] arr)
{
    double max = arr[0], min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] InitArray(int size, double start, double end)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() * (end - start) + start;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Write("[");
    foreach (var i in arr) Write($"{i},");
    WriteLine($"{arr[arr.Length - 1]}]");
}