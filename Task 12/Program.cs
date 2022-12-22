/*Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, 
то программа выводит остаток от деления.*/


using static System.Console;

Clear();

Write("Enter the first number: ");
int firstNumber = Convert.ToInt32(ReadLine());
Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(ReadLine());

WriteLine(secondNumber % firstNumber == 0 ?
        "The second number is a multiple of the first" : secondNumber % firstNumber);

