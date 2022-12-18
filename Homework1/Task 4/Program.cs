/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.*/

using static System.Console;

Clear();

Write("Enter first number: ");
int a = Convert.ToInt32(ReadLine());
Write("Enter second number: ");
int b = Convert.ToInt32(ReadLine());
Write("Enter third number: ");
int c = Convert.ToInt32(ReadLine());

int max = a;

if (a==b && b==c) WriteLine("Numbers are equal");
else{
if (b>max) max = b;
if (c>max) max = c;
WriteLine($"max = {max}");
}
