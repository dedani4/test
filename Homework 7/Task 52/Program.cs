/*Задача 52.Напишите программу реализующую методы,
формирования двумерного массива 
и массива средних арифметических значений каждого столбца.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using static System.Console;
Clear();

int[,] array = GetArray(4, 4);

PrintArray(array);
AvaragePerColoumn(array);


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

double[] AvaragePerColoumn(int[,] arr)
{
    double[] averagePerColoumnArray = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sumPerColoumn = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sumPerColoumn += arr[j, i];
        }
        averagePerColoumnArray[i] = sumPerColoumn / (arr.GetLength(0) - 1);
        Write($"{Math.Round(averagePerColoumnArray[i], 1)}; ");
    }
    return averagePerColoumnArray;
}