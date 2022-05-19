/*Задача 55:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/
using System;
Console.Clear();
Console.Write("Введите количество строк в массиве n - ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве m - ");
int m = int.Parse(Console.ReadLine());
if (n == m)
{
    int[,] NewArray = GetRandomArray(n, m, 1, 10);
    PrintArray(NewArray);
    Console.WriteLine();
    //NewArray = ChangeArray(NewArray);
    PrintArray(ChangeArray(NewArray));
}
else Console.WriteLine($"Для массива с такими параметрами провести сортировку не возможно!");

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
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newarray[i, j] = array[j, i];
        }
    }

    return newarray;
}
