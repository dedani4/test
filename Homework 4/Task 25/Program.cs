/*Напишите программу, реализующую метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B с использованием цикла.*/

using static System.Console;
Clear();

Write("Enter a number: ");
int A = Convert.ToInt32(ReadLine());
Write("Enter a degree : ");
int B = Convert.ToInt32(ReadLine());

WriteLine($"The number {A} to the power of {B} is {Exponentiate(A, B)}");


int Exponentiate(int n, int d)
{
    int exp = 1;
    for (int i = 0; i < d; i++)
    {
        exp *= n;
    }
    return exp;
}