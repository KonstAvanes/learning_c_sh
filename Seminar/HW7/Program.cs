Console.Clear(); // Clear the screen

// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.Write("Input quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[rows, columns];
// System.Console.WriteLine();
// System.Console.WriteLine($"Matrix [{rows}, {columns}] = : \n");

// for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             // Generate random matrix from -100 to 100, type is double
//             matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-100,101), 2, MidpointRounding.AwayFromZero);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");    
//     }




// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// // возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.Write("Input number of row of founding item: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of column of founding item: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [new Random().Next(2, 7), new Random().Next(2, 7)]; // Random matrix (2..6, 2..6)
// //int [,] matrix = new int [4, 4]; For test
// System.Console.WriteLine();

// System.Console.WriteLine($"Matrix [{matrix.GetLength(0)}, {matrix.GetLength(1)}] = : \n");

// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j <  matrix.GetLength(1); j++)
//         {
//             // Generate random matrix from from 0 to 40, type is int
//             matrix[i, j] = new Random().Next(41);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");   
//     }

// if (row < matrix.GetLength(0) && column < matrix.GetLength(1)) 
//     Console.WriteLine ($"The item with index [{row}, {column}] = : {matrix[row, column]}");
// else Console.WriteLine($"The item with index [{row}, {column}] is outed of range in matrix [{matrix.GetLength(0)}, {matrix.GetLength(1)}]");

// System.Console.WriteLine(); //For perfect view =)




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.Write("Input number of row of founding item: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of column of founding item: ");
// int column = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [new Random().Next(2, 7), new Random().Next(2, 7)]; // Random matrix (2..6, 2..6)
System.Console.WriteLine();

System.Console.WriteLine($"Matrix [{matrix.GetLength(0)}, {matrix.GetLength(1)}] = : \n");
double averageCount = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            // Generate random matrix from from 0 to 40, type is int
            matrix[i, j] = new Random().Next(41);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("\t");   
    }

System.Console.WriteLine(); //For perfect view =)

for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i <  matrix.GetLength(0); i++)
        {
            averageCount += matrix[i, j];
        }
        averageCount /= matrix.GetLength(0);
        Console.WriteLine($"Average value in Rows {j} = {Math.Round(averageCount,2, MidpointRounding.AwayFromZero)}");   
    }

System.Console.WriteLine(); //For perfect view =)
