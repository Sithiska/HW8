﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(string[,,] array)
{
    int num=10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = $"{num} ({i},{j},{k})";
                num++;
            }
}

void PrintArray(string[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[j, k, i],5}    ");
            }
            System.Console.WriteLine();
        }
    }
    
}


Console.Clear();
Console.WriteLine("Введите первое измерение массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе измерение массива");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье измерение массива");
int size3 = Convert.ToInt32(Console.ReadLine());
string[,,] array = new string[size1, size2, size3];
FillArray(array);
PrintArray(array);