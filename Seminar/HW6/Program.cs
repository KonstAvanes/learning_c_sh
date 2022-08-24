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

Console.Write(binNumber); 