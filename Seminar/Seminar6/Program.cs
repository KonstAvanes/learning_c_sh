Console.Clear(); // Clear the screen

//Seminar 6 (21.08.2022)


//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int size = 5;
// int[] array = new int[size];  // array = [0,0,0,0,0]

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(11); // 0-10
// }

// Console.WriteLine($" Array: [{String.Join("; ", array)}]");

// // 1. Создать массив, в который мы скопируем текущий

// int[] resultArray = new int[size];
// int lastIndex = size - 1;
// for (int i = 0; i < size; i++) //size = array.Length
// {
//     resultArray[i] = array[lastIndex - i];
// }
// Console.WriteLine($" Reverse array: [{String.Join("; ", resultArray)}]");




////Variant 2

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=CopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }

// // Задача 40:
// //  Напишите программу, которая принимает на вход три числа и проверяет,
// //  может ли существовать треугольник с сторонами такой длины.
// //  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
// //  двух других сторон.

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if(a + b > c && a + c > b && b + c > a) Console.WriteLine("Треугольник с сторонами такой длины существует.");
// else Console.WriteLine("Треугольник с сторонами такой длины не существует.");




//44

int N = 10;

int firstElement = 0; // Первое число по определению равно 0

int secondElement = 1; // Второе число равно 1

Console.WriteLine(firstElement);  // 1 число
Console.WriteLine(secondElement); // 2 число

for (int i = 3; i <= N; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
}


