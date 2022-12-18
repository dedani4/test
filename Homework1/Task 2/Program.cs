/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/

using static System.Console;

Clear();

WriteLine("Enter two numbers: ");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());

if (a>b) WriteLine($"max = {a}");
if (a<b) WriteLine($"max = {b}");
    else WriteLine ("numbers are equal");

