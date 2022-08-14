Console.Clear();

//Example 1
void Method1()
{
    System.Console.WriteLine("Method1");
}

Method1();

//Example 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Hello World");

Method2(msg: "Hello World");

//Example 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

//Example 4

string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // string.empty пустая строка или ""
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = Method4(10, "Hello World");
Console.WriteLine(res);

//cicle in cicle
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($" {i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}

// string Replace(string text, char oldValue, char newValue) // Код замены в тексте символа
// {
//     string result = string.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{str[i]}";
//     }
// }

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
