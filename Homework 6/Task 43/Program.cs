/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)*/

using static System.Console;
Clear();

Write("Enter 4 numbers with space: ");
int[] index = GetIndex(ReadLine());

WriteLine($"X = {FindCrossPoint(index).x}, Y = {FindCrossPoint(index).y}");



int[] GetIndex(string line)
{
    string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[lineArray.Length];
    for (int i = 0; i < lineArray.Length; i++)
    {
        arr[i] = Convert.ToInt32(lineArray[i]);
    }
    return arr;
}

Point FindCrossPoint(int[] arr)
{
    Point cross = new Point();
    cross.x = 1.0 * (arr[2] - arr[0]) / (arr[1] - arr[3]);
    cross.y = 1.0 * arr[1] * cross.x + arr[0];
    return cross;
}

struct Point
{
    public double x;
    public double y;
}