/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

using static System.Console;

Clear();

Write("Enter a number: ");
int number = Convert.ToInt32(ReadLine());

while (number<10){
    Write("Missed two digits, try again: ");
    number = Convert.ToInt32(ReadLine());
    }
while (number<100){
    Write("Missed third digit, try again: ");
    number = Convert.ToInt32(ReadLine());
    }
char[] numberArray = number.ToString().ToCharArray();
WriteLine(numberArray[numberArray.Length-3].ToString());