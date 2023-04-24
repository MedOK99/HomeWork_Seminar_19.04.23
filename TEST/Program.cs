// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int x = ReadNumberFromConsole("Введите X матрицы: ");
int y = ReadNumberFromConsole("Введите Y матрицы: ");
int z = ReadNumberFromConsole("Введите Z матрицы: ");
Console.WriteLine();

//Random rand = new Random();
int[,,] array3D = new int[x, y, z];                      // объявляю новый массив
CreateArray(array3D);                                    // запускаю метод для заполнения массива
PrintArray(array3D);                                     // запускаю метод печати массива

int ReadNumberFromConsole(string message = "")          // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

void CreateArray(int[, ,] array)               // метод для наполнения трёхмерного массива числами по порядку
{
  int p = 40;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        
        array[i, j, k] = p;
        p++;
      }
      
    }
  }
}

void PrintArray(int[,,] array)   // метод для вывода массива на печать (с табуляцией)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[      ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");  // табуляция
    }
    Console.Write("]\n");       // добавил "\n" чтобы убрать строку: Console.WriteLine();
  }
}






































