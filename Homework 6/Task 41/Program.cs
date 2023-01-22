/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using static System.Console;
Clear();

Write("Enter few numbers with space: ");
int[] array = GetArray(ReadLine());

WriteLine(CountPositiveNumber(array) > 1 ?
            $"There are {CountPositiveNumber(array)} positive numbers" :
            CountPositiveNumber(array) == 1 ? "There is one positive number" :
            "There is no positive numbers");



int[] GetArray(string line)
{
    string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[lineArray.Length];
    for (int i = 0; i < lineArray.Length; i++)
    {
        arr[i] = Convert.ToInt32(lineArray[i]);
    }
    return arr;
}

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item > 0) count++;
    }
    return count;
}