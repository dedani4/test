/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using static System.Console;
Clear();

int[,] array1 = GetArray(2, 2);
int[,] array2 = GetArray(2, 2);

WriteLine("First array");
PrintArray(array1);
WriteLine("Second array");
PrintArray(array2);
WriteLine("Result array");
PrintArray(MultiArrays(array1, array2));

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

int[,] MultiArrays(int[,] arr1, int[,] arr2)
{
    int temp;
    int[,] resultArray = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(1); i++)
    {
        for (int j = 0; j < resultArray.GetLength(0); j++)
        {
            temp = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                temp += arr1[i, k] * arr2[k, j];
            }
            resultArray[i, j] = temp;
        }

    }
    return resultArray;
}