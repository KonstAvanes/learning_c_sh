Console.Clear(); // Clear the screen

// int[] array = new int[12]; //

// int resultPositive = 0;
// int resultNegative = 0;

// int i = 0;
// int arraySize = array.Length;

// while (i < arraySize) {
//     array[i] =  new Random().Next(-9, 10);
//     i++;
// }

// System.Console.WriteLine($"{string.Join("; ", array)}");

// for (int j = 0; j < arraySize; j++)
// {
//     if (array[j] < 0) resultNegative +=array[j];
//     else resultPositive +=array[j];
// }

// Console.WriteLine($"Summ Positive = {resultPositive}");
// Console.WriteLine($"Summ Negative = {resultNegative}");

// New Exx 32
// int [] array = {0, -1, -2, 3, 4, 5, 6, 7};

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
//     // array[i] *= (-1)
// }

// Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");




// //New Exx 33

// int [] array = {0, -1, -2, 3, 4, 5, 6, 7};
// int searchNumber = Convert.ToInt32(Console.ReadLine());
// string flagResult = "не найден"; 
// // flagResult = false - element not found
// // flagResult = true - element found
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber) 
//     {
//         flagResult = "найден";
//         break; // break - ломает цикл
//     }
// }

// Console.WriteLine($"Элемент {searchNumber}: {flagResult}");




//Exx 35

int [] array = {0, -1, -2, 3, 4, 5, 6, 7,66,35,88};
// [10;99]

int count = 0; // количество чисел, принадлежащих диапазону [10;99]

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");



