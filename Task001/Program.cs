// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)                                     // проверка числа на натуральность 
{
  NaturalNumbers(number);
}
else
{
  Console.WriteLine("Вы ввели НЕ ВЕРНОЕ число! Повторите ввод.");
}

void NaturalNumbers(int num)                        // метод хвостовой рекурсии
{
  Console.Write($"{num} ");
  if (num == 1) return;
  NaturalNumbers(num - 1);
}
















