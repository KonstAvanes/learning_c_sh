Console.Clear(); // Clear the screen
// Methods for Homework exersices

int[,] GetArray(int m, int n) // Create array method
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(6);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix, string nameofmatrix) // Print array method
{
    System.Console.WriteLine($"{nameofmatrix} [{matrix.GetLength(0)}, {matrix.GetLength(1)}]:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}




// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int MinValueOfTotalRows (int[,] matrix)
// {
//     int[] totalRowMatrix = new int[matrix.GetLength(0)]; // For saving Value of total of rows.
//     int resultIndex = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            totalRowMatrix[i] += matrix[i, j];
//         }
//         Console.WriteLine($"Total of row № {i} = {totalRowMatrix[i]}");         
//     }

//    int minItem = totalRowMatrix[0];
//     for (int i = 0; i < totalRowMatrix.Length; i++)
//     {
//        if (minItem > totalRowMatrix[i]) resultIndex = i;
//     }
//     System.Console.WriteLine();
//     return resultIndex;
// }

// int [,] array = GetArray(rows, columns);
// PrintArray(array, "Array");
// System.Console.WriteLine();
// System.Console.WriteLine($"The minimum value of total of rows: {MinValueOfTotalRows(array)}");




// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int[,] matrixFirst = GetArray(rows, columns);
// int[,] matrixSecond = GetArray(rows, columns);
// PrintArray(matrixFirst, "Matrix1");
// PrintArray(matrixSecond, "Matrix2");

// if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0)) // Chech for matrixFirst(columns) = matrixSecond(rows)
// {
//     System.Console.WriteLine("The multiplication of matrix isn't possible");
//     return;
// }

// int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
// {
//     int[,] multMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

//     for (int i = 0; i < matrixOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixTwo.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixTwo.GetLength(0); k++)
//             {
//                 multMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
//             }


//         }
//     }
//     return multMatrix;
// }

// PrintArray(MultiplicationMatrix(matrixFirst, matrixSecond), "Result matrix");




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07