Console.Clear(); // Clear the screen, for all exersices



// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// // M = 4; N = 8. -> ""4, 6, 7, 8""

// System.Console.Write("Input Start number: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input End number: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();

//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// System.Console.WriteLine($"The row of natural numbers from {M} to {N} = {PrintNumbers(M, N)}");




// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// System.Console.Write("Input Start number: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input End number: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int PrintNumbers(int start, int end)
// {
//     if (start == end) return start;

//     return (start += PrintNumbers(start + 1, end));
// }

// System.Console.WriteLine($"The Sum of natural numbers from {M} to {N} = {PrintNumbers(M, N)}");




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

System.Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
System.Console.WriteLine($"The function Akkerman A({m}, {n}) = {Akkerman(m, n)}");