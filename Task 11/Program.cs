/*Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.*/

using static System.Console;

Clear();

int number = new Random().Next(99, 1000);

WriteLine(number);

WriteLine(number/100*10+number%10);
