/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/


using static System.Console;

Clear();

Write("Enter 5-digit number: ");
int number = Convert.ToInt32(ReadLine());

while (number < 10000 || number >100000) {
    Write("Wrong number, try again: ");
    number = Convert.ToInt32(ReadLine());
    }

int leftPart = number/1000;
int rightPart = number%10*10 + number%100/10;

WriteLine( leftPart + " " + rightPart);

WriteLine( leftPart == rightPart ? "it's a palindrome" : "it's not a palindrome");