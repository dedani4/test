/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/


using static System.Console;

Clear();

Write("Enter 3-digit number: ");
int number = Convert.ToInt32(ReadLine());

while (number<100 || number>999){
    Write("Wrong number, try again: ");
    number = Convert.ToInt32(ReadLine());
    }

// char[] numberArray = number.ToString().ToCharArray();
// WriteLine(numberArray[1].ToString());

WriteLine(number/10%10);



