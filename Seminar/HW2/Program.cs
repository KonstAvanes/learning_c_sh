Console.Clear(); //Clear screen for all exersices
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Input number: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
// string number = Console.ReadLine();
// Console.WriteLine($"Second digit of {number} is {number[1]}");

int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number % 100;
Console.WriteLine($"Second figure of {number} is {secondDigit}");