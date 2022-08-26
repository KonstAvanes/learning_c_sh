Console.Clear(); // Clear the screen

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// Console.Write("Input M of quantity of number: ");
// int quantity = Convert.ToInt32(Console.ReadLine());

// int[] numbers = new int[quantity];

// for (int i = 0; i < quantity; i++)
// {
//     Console.Write($"Input number {i+1}: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }

// int count = 0;
// for (int i = 0; i < quantity; i++)
// {
//     if (numbers[i] > 0) count++;
// }

// Console.WriteLine($"In array of numbers {String.Join(" ", numbers)}, quantity of (numbers > 0) = {count}");




// ДОП.ЗАДАЧА:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Input Decimal Number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"The Binary code of Decimal number {decimalNumber} is : "); 
string binNumber = "";

for (int temp = decimalNumber; temp !=0; decimalNumber = decimalNumber/2, temp = decimalNumber) binNumber += Convert.ToString(decimalNumber % 2);

for (int i = binNumber.Length-1; i >=0; Console.Write(binNumber[i]), i--); //Mirror output of binNumber for corrcted view




// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Line1 by function (y = k1 * x + b1), input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Line1 by function (y = k1 * x + b1), input k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Line2 by function (y = k2 * x + b2), input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Line1 by function (y = k2 * x + b2), input k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine();

// double x = (b1 - b2) / (k2 - k1);
// double y = k1 * x + b1;

// Console.WriteLine($"The lines (y = {k1} * x + {b1}) and (y = {k2} * x + {b2}) have intersection in point with coordinates ({x}; {y})");
