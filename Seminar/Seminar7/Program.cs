// Console.Clear(); // Clear the screen

// // Задаем массив и заполняем случайными числами
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     int summ = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)//строчки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
//         {
//             matrix[i, j] = new Random().Next(11);
//             System.Console.Write(matrix[i, j] + "\t");
//             if (i == j ) summ += matrix[i, j];
//         }
//         Console.WriteLine();    
//     }
//     return summ;
// }
// //int[,] resultMatrix = GetArray(rows, columns);

// System.Console.WriteLine(GetArray(rows, columns));

// // void PrintArray(int[,] inputMatrix)
// // {
// //     for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
// //     {
// //         for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
// //         {
// //             Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
// //         }
// //         Console.WriteLine();
// //     }
// // }


// // Console.Write("Введите количество строк ");
// // int rows = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите количество столбцов ");
// // int columns = Convert.ToInt32(Console.ReadLine());

// // int[,] GetArray(int m, int n) // m-строчки matrix.GetLength(0), n-столбцы matrix.GetLength(1)
// // {
// //     int[,] matrix = new int[m,n];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             matrix[i,j] = i + j;
// //         }
// //     }
// //     return matrix;
// // }

// // void PrintArray(int[,] inputMatrix)
// // {
// //     for (int i = 0; i < inputMatrix.GetLength(0); i++)
// //     {
// //         for (int m = 0; m < inputMatrix.GetLength(1); m++)
// //         {
// //             Console.Write(inputMatrix[i,m] + "\t");
// //         }
// //         Console.WriteLine();
// //     }
// // }

// // int[,] resaltMatrix = GetArray(rows, columns);

// // PrintArray(resaltMatrix);


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)//строчки
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// int sum = 0; // Изначальная сумма на главной диагонали
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//        if (i == j) sum += matrix[i,j]; // sum  = sum + matrix[i,j]
//     }
// }
// Console.WriteLine($"Сумма элементов главной диагонали: {sum}");

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)//строчки
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Результат: ");
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             Console.Write(Math.Pow(matrix[i, j], 2) + "\t");
//         }
//         else Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

