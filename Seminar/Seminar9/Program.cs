Console.Clear(); // Clear the screen, for all exersices

// int Factorial(int n)
// {
//     if (n == 1) return 1; // принято сначало описывать базовый случай

//     return n * Factorial(n - 1); // Потом рекурсивный случай
// }

// System.Console.WriteLine(Factorial(4));

// // EXX65
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();

//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// System.Console.WriteLine(PrintNumbers(1, N));

// // EXX67
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     if (num == 0) return 0;

//     return (num % 10 + SumNumbers(num / 10));
// }
// System.Console.WriteLine(SumNumbers(number));

//EXX69
int number = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());

int Power(int number, int power)
{
    if (power == 0) return 1;
    //if (power == 1) return number;
    return number * Power(number, power - 1);
}
System.Console.WriteLine(Power(number, degree));

