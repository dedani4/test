/*Напишите программу, реализующую метод, который принимает на вход число 
и выдаёт сумму цифр в числе.*/

using static System.Console;
Clear();

Write("Enter number: ");
int A = Convert.ToInt32(ReadLine());

WriteLine(SumDigitsNumber(A));

int SumDigitsNumber(int num)
{
    int sum = 0;
    for (; num > 0; num /= 10)
    {
        sum += num % 10;
    }
    return sum;
}