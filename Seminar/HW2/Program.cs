Console.Clear(); //Clear screen for all exersices
// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

////Variant 1, String method
// int number = new Random().Next(100,1000);
// Console.WriteLine("Рандомное число: " + number);
// string stringNumber = Convert.ToString(number);
// Console.WriteLine($"Second digit of {number} is {stringNumber[1]}");

//// Variant 2, Math method
// int number = new Random().Next(100,1000);
// Console.WriteLine("Рандомное число: " + number);
// int secondDigit = number / 10; 
// secondDigit = secondDigit % 10;
// Console.WriteLine($"Second digit of {number} is {secondDigit}");


//// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//// 645 -> 5
//// 78 -> третьей цифры нет
//// 32679 -> 6

// int number = new Random().Next(10,500); // Generate random number from 10 to 500
// Console.WriteLine("Рандомное число: " + number);

// if (number >= 100)
//     {
//     int thirdDigit = number % 10; 
//     Console.WriteLine($"Last digit of {number} is {thirdDigit}");
//     }
// else Console.WriteLine($"The {number} have only two digits, third Digit is absented");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.Write("Input number Day of the week: ");
// int dayofWeek = Convert.ToInt32(Console.ReadLine());

// if ((dayofWeek == 6) || (dayofWeek == 7)) Console.WriteLine ($"The day of the week is {dayofWeek} it is weekends =)");
// else Console.WriteLine ($"The day of the week is {dayofWeek} it is workday :( ");