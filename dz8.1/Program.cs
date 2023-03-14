﻿// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] MatrixRandom(int row, int column)
{
int[,] matrix = new int[row, column];
Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
           {
           matrix[i, j] = rnd.Next(2, 10);
           }
      }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
       System.Console.Write(matrix[i, j] + " ");
       }
       Console.WriteLine();
    }
}

void SortToLower(int[,]matrix )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k <matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp =matrix [i, k + 1];
                   matrix [i, k + 1] = matrix[i, k];
                   matrix[i, k] = temp;
                }
            }
        }
    }
}


System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = MatrixRandom(row, column);
PrintMatrix(matrix);
SortToLower(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);