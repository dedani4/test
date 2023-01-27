/*Задача 50.Напишите программу реализующую метод, 
принимающий позиции элемента в двумерном массиве, 
и возвращающий значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1; 7->такого элемента в массиве нет
1; 1-> 9*/

using static System.Console;
Clear();

Write("Enter row and coloumns numbers with space: ");
int[] parameters = GetParameters(ReadLine());
int[,] array = GetArray(4, 5);

PrintArray(array);
GetElement(parameters[0], parameters[1]);



int[] GetParameters(string line)
{
    string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] par = new int[lineArray.Length];
    for (int i = 0; i < lineArray.Length; i++)
    {
        par[i] = Convert.ToInt32(lineArray[i]);
    }
    return par;
}

int[,] GetArray(int rows, int coloumns)
{
    int[,] arr = new int[rows, coloumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloumns; j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
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

void GetElement(int r, int c)
{
    WriteLine(r < array.GetLength(0) && c < array.GetLength(1) ? $"{array[r, c]} " : "no such element");
}