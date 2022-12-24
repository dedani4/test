/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

using static System.Console;

Clear();

Write("Enter a number: ");
int N = Convert.ToInt32(ReadLine());

for (int i = 1; i <= N; i++) WriteLine(i + " " + i*i*i);
