Console.Clear();
// //Задача 9

// int number = new Random().Next(10, 100);
// System.Console.WriteLine("Number random: " + number);

// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int max = firstDigit;

// if (max < secondDigit) max = secondDigit;
// System.Console.WriteLine($"Maximum of {number}: {max}");



// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// //456 -> 5
// //782 -> 8
// //918 -> 1

// int number = new Random().Next(100,1000);
// Console.WriteLine("Рандомное число: " + number);

// int firstDigit = number / 100; //firstDigit-первая цифра числа: 78-7
// int secondDigit = number % 10; //secondDigit-вторая цифра числа:78-8
// int digit = firstDigit * 10 + secondDigit;
// Console.WriteLine(digit);

////2 variant
// string inputNumber = Console.ReadLine(); //"456"
// Console.WriteLine(inputNumber[0]+ inputNumber[2]);




// //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0) Console.WriteLine("кратно");
// else Console.WriteLine("не кратно, остаток от деления равен: " + (number1 % number2));



// //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");
// else Console.WriteLine("Не кратно");



// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// // 5, 25  ->  да
// // -4, 16  ->  да
// // 25, 5  ->  да
// // 8,9  ->  нет

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2 || number2 == number1 * number1) Console.WriteLine("Одно число является квадратом другого");
// else Console.WriteLine("Ни одно из чисел не является квадратом другого");


