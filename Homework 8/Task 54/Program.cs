/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using static System.Console;
Clear();

Write("Enter array row qty: ");
int A = Convert.ToInt32(ReadLine());
while (A <= 0)
{
    Write("Wrong qty, try again: ");
    A = Convert.ToInt32(ReadLine());
}

Write("Enter array coloumn qty: ");
int B = Convert.ToInt32(ReadLine());
while (B <= 0)
{
    Write("Wrong qty, try again: ");
    B = Convert.ToInt32(ReadLine());
}

int[,] array = GetArray(A, B);

PrintArray(array);
RearrangeArrayRow(array);
WriteLine();
PrintArray(array);


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

void RearrangeArrayRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1 - j; k++)
            {
                int temp = 0;
                if (arr[i, k] < arr[i, k + 1])
                {
                    temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }

            }

        }

    }
}