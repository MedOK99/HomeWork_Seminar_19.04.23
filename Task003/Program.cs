// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int m = ReadNumberFromConsole("Введите значение m: ");
int n = ReadNumberFromConsole("Введите значение m: ");
Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)                              
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int ReadNumberFromConsole(string message = "")          // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}















