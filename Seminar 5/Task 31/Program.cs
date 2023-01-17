/*Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.*/

using static System.Console;
Clear();

Write("Enter array size, min and max with space: ");
int[] parameters = ReadParametres(ReadLine());
int[] array = InitArray(parameters[0], parameters[1], parameters[2]);

PrintArray(array);
WriteLine($"{NegSum(array)}\n{PosSum(array)}");

// split string to int[]
int[] ReadParametres(string line)
{
    string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[lineArray.Length];
    for (int i = 0; i < lineArray.Length; i++)
    {
        array[i] = Convert.ToInt32(lineArray[i]);
    }
    return array;
}

int NegSum(int[] arr)
{
    int negSum = 0;
    foreach (int i in arr) if (i < 0) negSum += i;
    return negSum;
}

int PosSum(int[] arr)
{
    int posSum = 0;
    foreach (int i in arr) if (i > 0) posSum += i;
    return posSum;
}

int[] InitArray(int size, int start, int end)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]},");
    }
    WriteLine($"{arr[arr.Length - 1]}]");
}