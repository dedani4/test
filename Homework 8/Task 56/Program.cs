/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using static System.Console;
Clear();

Write("Enter array size: ");
int A = Convert.ToInt32(ReadLine());
while (A <= 0)
{
    Write("Wrong size, try again: ");
    A = Convert.ToInt32(ReadLine());
}

int[,] array = GetArray(A, A);

PrintArray(array);
WriteLine();
WriteLine(SmallestSumRow(array));


int[,] GetArray(int rows, int coloumns)
{
    int[,] arr = new int[rows, coloumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloumns; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        Write("\n");
    }
}

int SmallestSumRow(int[,] arr)
{
    int temp = 0;
    int row = 0;
    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum > temp)
        {
            temp = sum;
            row = i;
        }
        sum = 0;
    }
    return row;
}