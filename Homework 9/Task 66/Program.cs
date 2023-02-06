/*Задача 66: Напишите программу, которая реализует рекурсивный метод 
нахождения суммы натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

using static System.Console;
Clear();

Write("Enter a number from: ");
int A = Convert.ToInt32(ReadLine());
Write("Enter a number to: ");
int B = Convert.ToInt32(ReadLine());
int sum = SumNaturalNumber(A, B);
Write($"{sum}");

int SumNaturalNumber(int A, int B)
{
    return SumNaturalNumber(A + 1, B) + A;
}
