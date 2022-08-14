Console.Clear(); // Clear the screen
//Seminar 4

// Console.Write("Input A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= A; i++)
// {
//     sum += i;

// }

// System.Console.WriteLine($"Summary 1 to {A}: {sum}");



//Method function

// Console.Write("Input A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int GetSumNumbers(int numbers)
// {
//     int sum = 0;
//     int start = 1;

//     while (start <= numbers)
//     {
//         sum += start;
//         start++;
//     }
       
//     return sum;
// }

// System.Console.WriteLine($"Summary 1 to {A}: {GetSumNumbers(A)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Res = number;
// int count = 0;
// while (Res != 0)
// {
//     Res = Res / 10;
//     count++;
// }
// Console.WriteLine(count);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Res = number;
// int count = 0;
// while (Res != 0)
// {
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int fact = 2;
// for (int i = 3; i <= N; i++)
// {
//     fact = fact*i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {N} равно {fact}");




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] nums = new int[8];
for (int i = 0; i < 8; i++)
{
    nums [i] = new Random().Next(2);
    Console.Write($"{nums [i]} ");
}

Console.WriteLine(string.Join(";", nums)); // Out array uses string.Join
