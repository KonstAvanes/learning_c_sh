Console.Clear(); // Clear the screen, for all exersices

// Methods for Homework exersices
int[,] GetArray(int m, int n) // Create array method
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(100); // Value of max random numbers
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix, string nameOfMatrix) // Print array method
{
    System.Console.WriteLine($"{nameOfMatrix} [{matrix.GetLength(0)}, {matrix.GetLength(1)}]:");
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




// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.Write("Input quantity of rows of matrix: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input quantity of columns of matrix: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// int[,] array = GetArray(rows, columns);
// PrintArray(array, "BasicArray");

// int[,] ReverseMatrix(int[,] matrix)
// {
//     //int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1) - 1;)
//         {

//             if (matrix[i, j] < matrix[i, j + 1])
//             {
//                 int tempValue = matrix[i, j + 1];
//                 matrix[i, j + 1] = matrix[i, j];
//                 matrix[i, j] = tempValue;
//                 j = 0;
//             } else j++;

//         }
//     }
//     return matrix;
// }

// PrintArray(ReverseMatrix(array), "ReverseMatrix");




// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Input quantity of rows of matrix: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input quantity of columns of matrix: ");
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

// Console.Write("Input quantity of rows of matrix: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input quantity of columns of matrix: ");
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

// int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo) //Method for matrix multiplication
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




// // // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // // Массив размером 2 x 2 x 2
// // // 66(0,0,0) 25(0,1,0)
// // // 34(1,0,0) 41(1,1,0)
// // // 27(0,0,1) 90(0,1,1)
// // // 26(1,0,1) 55(1,1,1)

// // Console.Write("Input quantity of rows of matrix: ");
// // int rows = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Input quantity of columns of matrix: ");
// // int columns = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Input depth of matrix: ");
// // int depth = Convert.ToInt32(Console.ReadLine());

// // System.Console.WriteLine();

// // int[,,] matrix = new int[rows, columns, depth];


// // HashSet<int> numbers = new HashSet<int>(); // HashSet Can contain only unique numbers
// // //Random r = new Random();

// // int GenerateUniqueNumber()
// // {
// //     while (true)
// //     {
// //         int n = new Random().Next(10, 50);// Generate unique number XX
// //         if (!numbers.Contains(n))
// //         {
// //             numbers.Add(n);
// //             return n;
// //         }
// //     }
// // }

// // for (int i = 0; i < rows; i++) //Create random matrix
// // {
// //     for (int j = 0; j < columns; j++)
// //     {
// //         for (int k = 0; k < depth; k++)
// //         {
// //             matrix[i, j, k] = GenerateUniqueNumber();
// //         }
// //     }
// // }


// // for (int k = 0; k < depth; k++) //Print matrix, view as task
// // {
// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < columns; j++)
// //         {
// //             Console.Write($" {matrix[i, j, k]} ({i}, {j}, {k})\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07





// /////From internet GITHUB https://gist.github.com/gmakc-094423

// // Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Clear();
// Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void CreateArray(int[,,] array3D) //Create random array
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 21);
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 21);
//                     j = 0;
//                 }
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

// // Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Наименьший элемент - 1, на выходе получим
// // следующий массив:
// // 9 4 2
// // 2 2 6
// // 3 4 7


// Console.Clear();
// Console.WriteLine($"Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");
// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int[,] positionSmallElement = new int[1, 2];
// positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
// Console.Write($"Позиция элемента: \n");
// WriteArray(positionSmallElement);

// int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
// DeleteLines(array, positionSmallElement, arrayWithoutLines);
// Console.WriteLine($"\nПолучившийся массив:");
// WriteArray(arrayWithoutLines);


// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FindPositionSmallElement(int[,] array, int[,] position)
// {
//     int temp = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] <= temp)
//             {
//                 position[0, 0] = i;
//                 position[0, 1] = j;
//                 temp = array[i, j];
//             }
//         }
//     }
//     Console.WriteLine($"\nMинимальный элемент: {temp}");
//     return position;
// }

// void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
// {
//     int k = 0, l = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
//             {
//                 arrayWithoutLines[k, l] = array[i, j];
//                 l++;
//             }
//         }
//         l = 0;
//         if (positionSmallElement[0, 0] != i)
//         {
//             k++;
//         }
//     }
// }




// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}