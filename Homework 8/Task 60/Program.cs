/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

using static System.Console;
Clear();

int[,,] array = GetArray(2, 2, 2);

PrintArray(array);



int[,,] GetArray(int rows, int coloumns, int third)
{
    // СОЗДАЕМ МАССИВ ЧИСЕЛ ОТ 10 до 99
    int[] nonRepeatArray = new int[90];
    for (int i = 0; i < nonRepeatArray.Length; i++)
    {
        nonRepeatArray[i] = i + 10;
    }
    // Перемешиваем массив
    for (int i = nonRepeatArray.Length - 1; i >= 1; i--)
    {
        int r = new Random().Next(i + 1);

        int temp = nonRepeatArray[r];
        nonRepeatArray[r] = nonRepeatArray[i];
        nonRepeatArray[i] = temp;
    }

    // Создаем трехмерный массив и заполняем его
    int[,,] arr = new int[rows, coloumns, third];

    int x = 0;
    for (int k = 0; k < rows; k++)
    {
        for (int i = 0; i < coloumns; i++)
        {
            for (int j = 0; j < third; j++)
            {
                arr[k, i, j] = nonRepeatArray[x];
                x++;
            }

        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {


                Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
            WriteLine();
        }

    }
}

