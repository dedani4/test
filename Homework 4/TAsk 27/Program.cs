/*Напишите программу, реализующую метод, который принимает на вход число 
и выдаёт сумму цифр в числе.*/

using static System.Console;
Clear();

Write("Enter a number: ");
int A = Convert.ToInt32(ReadLine());

WriteLine($"The sum of the digits of the number {A} is {SumDigitsNumber(A)}");

int SumDigitsNumber(int num)
{
    int sum = 0;
    for (; num > 0; num /= 10)
    {
        sum += num % 10;
    }
    return sum;
}