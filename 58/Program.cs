﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 16);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayResult = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayResult[i, j] = 0;

            for (int l = 0; l < arrayA.GetLength(1); l++)
            {
                arrayResult[i, j] += arrayA[i, l] * arrayB[l, j];
            }
        }
    }
    return arrayResult;
}

Console.Clear();
Console.WriteLine("Введите количество строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы A:");
int colsA = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[rowsA, colsA];
FillArray(arrayA);
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Введите количество строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы B:");
int colsB = Convert.ToInt32(Console.ReadLine());
int[,] arrayB = new int[rowsB, colsB];
FillArray(arrayB);
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Результат умножения двух матриц");
PrintArray(MultiplicationMatrix(arrayA, arrayB));
