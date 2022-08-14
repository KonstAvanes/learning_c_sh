Console.Clear(); //Clear screen for all exersices

// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// string number = Console.ReadLine();
// int numberLength = number.Length;
// int beginIndex = 0;

// for (int i = (numberLength-1); i >= 0; i--)
// {
//     if (number[i] == number[beginIndex]) beginIndex++;
    
//     else break;
// }

// if (beginIndex == numberLength) Console.WriteLine($"The number={number} is Palindrom =)");
// else Console.WriteLine($"The number = {number} is none Palindrome =)");

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// //Random coordinates of the point A(x1, y1, z1)
// int x1 = new Random().Next(-100, 100);
// int y1 = new Random().Next(-100, 100);
// int z1 = new Random().Next(-100, 100);

// //Random coordinates of the point B(x2, y2, z2)
// int x2 = new Random().Next(-100, 100);
// int y2 = new Random().Next(-100, 100);
// int z2 = new Random().Next(-100, 100);

// double result = Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2 - y1), 2)+Math.Pow((z2 - z1), 2));

// Console.WriteLine($"Distance between points A ({x1}, {y1}, {z1}) and B ({x2}, {y2}, {z2}) = {Math.Round(result,2)}");




// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Input Number");
// int number = Convert.ToInt32(Console.ReadLine());

// int index = 1;

// while (index <= number) {
//    Console.Write($"{Math.Pow(index, 3)}\t");
//    index++;
// }