Console.Clear(); // Clear the screen

// System.Console.WriteLine("Input X");
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) System.Console.WriteLine("X, Y at 1 quarter");
// else if (x < 0 && y > 0) System.Console.WriteLine("X, Y at 2 quarter");
// else if (x > 0 && y < 0) System.Console.WriteLine("X, Y at 4 quarter");
// else if (x < 0 && y < 0) System.Console.WriteLine("X, Y at 3 quarter");
// else System.Console.WriteLine("quarter is absented");

// Exx01.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// System.Console.WriteLine("Input quarter of X,Y");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1) System.Console.WriteLine("X > 0, Y > 0");
// else if (x == 2) System.Console.WriteLine("X < 0, Y > 0");
// else if (x == 3) System.Console.WriteLine("X < 0, Y < 0");
// else if (x == 4) System.Console.WriteLine("X > 0, Y < 0");
// else System.Console.WriteLine("quarter is absented");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// int x1 = new Random().Next(-100, 100);
// int y1 = new Random().Next(-100, 100);

// int x2 = new Random().Next(-100, 100);
// int y2 = new Random().Next(-100, 100);

// double result = Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2 - y1), 2));

// Console.WriteLine($"Разница между числами с координатами A({x1}, {y1}) и B({x2}, {y2}) = {Math.Round(result,2)}");


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


System.Console.WriteLine("Input Number");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;

while (index <= number) {
   Console.Write($"{Math.Pow(index, 2)}\t");
   index++;
}