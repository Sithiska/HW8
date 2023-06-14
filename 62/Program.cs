﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] FillArray()
{
    int n = 4;
    string[,] result = new string[n, n];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num < result.GetLength(0) * result.GetLength(1)+1)
    {
        if (num<10)
            result[i, j] = "0" + Convert.ToString(num);
        else
            result[i,j] = Convert.ToString(num);
        num++;
        if (i < j + 2 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j > result.GetLength(0) - 2)
            i++;
        else if (i+1 > j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],2}    ");
        System.Console.WriteLine();
    }
}

Console.Clear();
PrintArray(FillArray());