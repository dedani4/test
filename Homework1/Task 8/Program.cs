/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

using static System.Console;

Clear();

Write("Enter a number: ");
int n = Convert.ToInt32(ReadLine());

int countEven = 1;
while (countEven <= n){
    if (countEven%2 == 0) Write ($"{countEven}, ");
    countEven++;
}
