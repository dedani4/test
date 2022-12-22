/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/

using static System.Console;

Clear();

Write("Enter a week day number: ");
int number = Convert.ToInt32(ReadLine());

while (number>7 || number<1){
    Write("There are 7 days in a week, try again: ");
    number = Convert.ToInt32(ReadLine());
    }
WriteLine((number == 6 || number == 7) ? "Weekend" : "Workday");