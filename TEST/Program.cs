// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(num1, num2);

void NaturalNumbersRange(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m + 1, n);
    }
    else if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m - 1, n);
    
    }
    else
    {
        Console.Write($"{m} ");
    }
}





































