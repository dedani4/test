/*Задача 68: Напишите программу реализующую метод вычисления 
функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/


using static System.Console;
Clear();

Write("Enter a number from: ");
int A = Convert.ToInt32(ReadLine());
Write("Enter a number to: ");
int B = Convert.ToInt32(ReadLine());


int result = Akkerman(A, B);

WriteLine($"{result}");

int Akkerman(int A, int B)
{
    if (A == 0) return B + 1;
    else if (A > 0 && B == 0) return Akkerman(A - 1, 1);
    else return Akkerman(A - 1, Akkerman(A, B - 1));
    return 0;

}