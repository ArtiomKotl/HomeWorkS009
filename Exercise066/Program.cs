// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int m, int n)
{
  if (m == n)
  {
    return m;
  }
  else if (m > n)
  {
    return m + SumNumber(m - 1, n);
  }
  else if (m < n)
  {
    return n + SumNumber(m, n - 1);
  }
  else
  {
    return -1;
  }
}

int GetNumber(string name)
{
  Console.Write($"Введите значение {name} =  ");
  int.TryParse(Console.ReadLine(), out int num);
  while (num <= 0)
  {
    Console.WriteLine("Попробуйте ещё: ");
    int.TryParse(Console.ReadLine(), out num);
  }
  return num;
}

int M = GetNumber("M");
int N = GetNumber("N");
if (M > N)
  Console.WriteLine($"Сумма чисел между {N} и {M} = {SumNumber(M, N)}");
else
  Console.WriteLine($"Сумма чисел между {M} и {N} = {SumNumber(M, N)}");