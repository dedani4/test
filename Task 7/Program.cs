using static System.Console;
 
Write ("Enter 3-digit number:");
 
int N = Convert.ToInt32(ReadLine());

Write($"{N%10}");
