/*Напишите программу, реализующую метод, который формирует 
массив случайных целых чисел из 8 элементов и выводит их на экран.*/

using static System.Console;
Clear();

Write("Enter array size: ");
int A = Convert.ToInt32(ReadLine());
while (A <= 0)
{
    Write("Wrong size, try again: ");
    A = Convert.ToInt32(ReadLine());
}

Write("Enter interval start ");
int B = Convert.ToInt32(ReadLine());

Write("Enter interval end: ");
int C = Convert.ToInt32(ReadLine());
while (C <= B)
{
    Write("Wrong interval end, try again: ");
    C = Convert.ToInt32(ReadLine());
}


int[] array = InitArray(A, B, C);
PrintArray(array);

FillArray(array, B, C);
PrintArray(array);




int[] InitArray(int size, int start, int end)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

void FillArray(int[] arr, int start, int end)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}