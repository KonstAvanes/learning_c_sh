Console.Clear(); //For all exx

//Exx01
// Console.Clear();
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// //int result = Convert.ToInt32(Math.Pow(number, 2));
// System.Console.WriteLine("Square : " + square);


// //Exx02
// Console.Write("Input number #1: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());

// Console.Write(value: "Input number #2: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// if (firstnumber == secondnumber * secondnumber)
// {
//     System.Console.WriteLine("Firstnumber = power: " + secondnumber);
// }
// else System.Console.WriteLine("Firstnumber =  not power: " + secondnumber);

//Exx03
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number * (-1);
while (i <= number)
{
 System.Console.Write(i + " ");   
i++;
}
