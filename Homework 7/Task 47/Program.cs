/*Задача 47.Напишите программу реализующую метод, 
который возвращает массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using static System.Console;
Clear();

Write("Enter array size rows and coloumns with space: ");
int[] parameters = GetParameters(ReadLine());
double[,] array = GetArray(parameters[0], parameters[1]);

PrintArray(array);



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

double[,] GetArray(int rows, int coloumns)
{
    double[,] arr = new double[rows, coloumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloumns; j++)
        {
            arr[i, j] = new Random().NextDouble() * (10 + 10) - 10;
        }

    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{Math.Round(arr[i, j], 1)} ");
        }
        Write("\n");
    }
}
