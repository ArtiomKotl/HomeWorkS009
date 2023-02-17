// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumber(int N)
{
  if (N == 1)
  {
    Console.Write($"{N}");
  }
  else
  {
    Console.Write($"{N}, ");
    PrintNumber(N - 1);
  }
}

int GetNumber()
{
  Console.Write($"Введите значение числа N : ");
  int.TryParse(Console.ReadLine(), out int result);
  return result;
}

int num = GetNumber();
PrintNumber(num);