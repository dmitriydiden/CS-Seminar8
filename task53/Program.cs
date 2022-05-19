/* **Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/
using System;
Console.Clear();
int[,] NewArray = GetRandomArray(4,4,1,10);
PrintArray(NewArray);
Console.WriteLine();
NewArray = ChangeArray(NewArray);
PrintArray(NewArray);


int[,] GetRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array=new int[rows,columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i,j]} ");  
      }
      Console.WriteLine();  
    }
}

int[,] ChangeArray(int[,] array)
{
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int result = 0;
        result = array[i, j];
        array[i, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = result;
    }
    return array;
}