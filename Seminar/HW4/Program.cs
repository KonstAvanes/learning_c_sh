Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input power of {number}: ");
int power = Convert.ToInt32(Console.ReadLine());
int numberPower = 1;
//Console.WriteLine($"Number {number} in power {power} = {Math.Pow(number, power)}"); Incorrect variant
for (int i = 1; i <= power; i++) {
    numberPower *= number;
}
Console.WriteLine($"Number {number} in power {power} = {numberPower}");



// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write($"Amount digits of number {number}: ");

// int sum = 0;
// while (number != 0) {
//     sum += number % 10;
//     number /= 10;
// }
// Console.Write(sum);




// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// Console.Write("Input length of array: ");
// int [] array = new int[Convert.ToInt32(Console.ReadLine())];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(100); //Random item of array from 0 to 99
//     Console.Write($"{array[i]} \t");
// }
