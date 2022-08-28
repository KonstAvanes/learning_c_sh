Console.Clear(); // Clear the screen

// Seminar 8

// // Задаем массив и заполняем случайными числами
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// // Метод замены строк

// void ChangeRows(int[,] inputMatrix)
// {
//     int indexLastRow = inputMatrix.GetLength(0) - 1; // size - 1
//     for (int i = 0; i < inputMatrix.GetLength(1); i++)
//     {
//         int temp = inputMatrix[0, i];
//         inputMatrix[0, i] = inputMatrix[indexLastRow, i];
//         inputMatrix[indexLastRow, i] = temp;
//     }
// }

// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// Console.WriteLine("Result: ");
// ChangeRows(resultMatrix);
// PrintArray(resultMatrix);


// Session Room
//
// Метод замены строк

// int[,] ChangeRows(int[,] inputMatrix)
// {
//     int[,] result = new int[rows, columns];


//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {

//             result[j, i] = inputMatrix[i, j];


//         }
//     }


//     return result;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// Console.WriteLine("Result: ");
// PrintArray(ChangeRows(resultMatrix));


//Decision of Mick
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = Convert.ToInt32(Console.ReadLine());
// if (rows != columns)
// {
// Console.WriteLine("Заменить элементы нельзя");
// return; ///ВАЖНО, возвращает в начало программы
// }
// int[,] GetArray(int m, int n)
// {
// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(11);
// }
// }
// return matrix;
// }

// void PrintArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i, j] + "\t");
// }
// Console.WriteLine();
// }
// }

// // Метод замены строк

// int[,] ChangeArray(int[,] matrix)
// {
// int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// result[j,i] = matrix[i, j];
// }
// }
// return result;
// }

// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// Console.WriteLine("Result: ");
// PrintArray(ChangeArray(resultMatrix));

//*55 задачка: *
int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int indexMinRows = 0; // строчка
int indexMinColumns = 0; // столбец с мин элементом

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
        if (minElement > matrix[i, j]) // 5 > 0, min = 0
        {
            indexMinColumns = j;
            indexMinRows = i;
            minElement = matrix[i, j];
        }
    }
    Console.WriteLine();
}
System.Console.WriteLine("Result: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (indexMinRows != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexMinColumns != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}