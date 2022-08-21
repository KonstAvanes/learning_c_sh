Console.Clear(); // Clear the screen

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int [9];
// int count = 0;
// int arraySize = array.Length;
// System.Console.Write($"Array size [{arraySize}] = : ");
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     System.Console.Write($"\t {array[i]}");
//     if (array[i] % 2 == 0) count++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Quantity of even numbers of Array = {count}");
// System.Console.WriteLine();



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int [4];
// int total = 0;
// int arraySize = array.Length;
// System.Console.Write($"Array size [{arraySize}] = : ");
// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(99);
//     System.Console.Write($"\t {array[i]}");
//     if (i % 2 != 0) total += array[i];
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Total of elements are stood on odd positions = {total}");
// System.Console.WriteLine();




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [4];
int arraySize = array.Length;

System.Console.Write($"Array size [{arraySize}] = : "); //Fill the array with double numbers with round for 2 digits after comma.
for (int i = 0; i < arraySize; i++)
{
    array[i] = Math.Round (new Random().NextDouble() * 100, 2, MidpointRounding.AwayFromZero); //MidpointRounding.AwayFromZero дл округления в большую сторону
    System.Console.Write($"\t {array[i]}");
}

double minItem = array[0]; //Max and Min default first element of array
double maxItem = array[0];

for (int i = 0; i < arraySize; i++)
{
    if (array[i] < minItem) minItem = array[i];
    else if (array[i] > maxItem) maxItem = array[i];
}

System.Console.WriteLine();
System.Console.WriteLine($"Difference between Max element {maxItem} and Min element {minItem} = {Math.Round (maxItem - minItem, 2, MidpointRounding.AwayFromZero)}");
System.Console.WriteLine();