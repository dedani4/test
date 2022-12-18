/*Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

using static System.Console;

Clear();

Write("Enter a number: ");
int a = Convert.ToInt32(ReadLine());

if (a%2 == 0) Write($"{a} is even number");
else Write($"{a} is odd number");
