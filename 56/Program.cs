﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int MinSummRow(int[,] array)
{
    int sumRow = 0;
    int minSumRow = 0;
    int minRow = 1;
    for (int i = 0; i < 1; i++)
        for (int j = 0; j < array.GetLength(1); j++)
            minSumRow+=array[i,j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow+=array[i,j];
        if (sumRow<minSumRow)
        {
            minSumRow=sumRow;
            minRow = i+1;
        }  
        sumRow=0;    
    }
    return minRow;
}




    Console.Clear();
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSummRow(array)} строка.");