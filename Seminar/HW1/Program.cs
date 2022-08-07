Console.Clear(); //Clear screen for all exersices

// // ЗАДАЧА 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Write("Input number 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2) Console.WriteLine("Number 1 is biggest than number 2.");
 
// else if (number1 < number2) Console.WriteLine("Number 2 is biggest than number 1."); 
    
//     else System.Console.WriteLine("Number 1 and number 2 are equal");




// // ЗАДАЧА 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.Write("Input number 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 3: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int maxNumber = number1;

// if (maxNumber < number2) maxNumber = number2; 

// if (maxNumber < number3) maxNumber = number3;

// System.Console.WriteLine("Max number = " + maxNumber);




// // ЗАДАЧА 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.Write("Input number 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number 3: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if (Convert.ToBoolean(number1 % 2)) Console.WriteLine("Number 1: is ODD"); //Конвертирую в Boolean , если 1 (TRUE) то нечетное (ODD), остаток от операции %
// else Console.WriteLine("Number 1: is EVEN"); // Иначе 0 (False) EVEN (нечетное)

// if (Convert.ToBoolean(number2 % 2)) Console.WriteLine("Number 3: is ODD"); //Конвертирую в Boolean , если 1 (TRUE) то нечетное (ODD), остаток от операции %
// else Console.WriteLine("Number 2: is EVEN"); // Иначе 0 (False) EVEN (нечетное)

// if (Convert.ToBoolean(number3 % 2)) Console.WriteLine("Number 3: is ODD"); //Конвертирую в Boolean , если 1 (TRUE) то нечетное (ODD), остаток от операции %
// else Console.WriteLine("Number 3: is EVEN"); // Иначе 0 (False) EVEN (нечетное)




// // ЗАДАЧА 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= number)
// {
//  if (!Convert.ToBoolean(i % 2)) Console.Write(i + " ");  
// i++;
// }