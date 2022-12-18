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

if(a>b){
    if(a>c || a==c) Write($"max = {a}");
        else Write($"max = {c}");
}
if(a<b){
    if(b>c || b==c) Write($"max = {b}");
        else Write($"max = {c}");
}
if(a==b && b==c) WriteLine("All numbers are equal");