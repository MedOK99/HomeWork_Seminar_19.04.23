// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && m >= 1)                                     // проверка чисел на натуральность
{
  SumOfElements(n, m);
  Console.WriteLine($"Сумма промежуточных элементов равна: {SumOfElements(n, m)}");
}
else
{
  Console.WriteLine("Вы ввели НЕ ВЕРНОЕ число! Повторите ввод.");
}

int SumOfElements(int n, int m)                           // рекурсивный метод подсчёта суммы промежуточных элементов
{
  if (n == m) return n;
  if (n > m) return SumOfElements(m + 1, n) + m;
  else return SumOfElements(n + 1, m) + n;
}














