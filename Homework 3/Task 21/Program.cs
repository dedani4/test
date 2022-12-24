/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/


using static System.Console;

Clear();

Write("Enter x1 coordinate: ");
int x1 = Convert.ToInt32(ReadLine());
Write("Enter y1 coordinate: ");
int y1 = Convert.ToInt32(ReadLine());
Write("Enter z1 coordinate: ");
int z1 = Convert.ToInt32(ReadLine());
Write("Enter x2 coordinate: ");
int x2 = Convert.ToInt32(ReadLine());
Write("Enter y2 coordinate: ");
int y2 = Convert.ToInt32(ReadLine());
Write("Enter z2 coordinate: ");
int z2 = Convert.ToInt32(ReadLine());

WriteLine ("Distance between 2 points is " + 
            Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2)));