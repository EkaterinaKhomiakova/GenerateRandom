// Задайте двумерный массив.Найдите сумму элементов
// находящихся на главной диагонали (с индексами (0,0);(1;1) и т.д.
// Например задан массив,
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали 1+9+2 = 12
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

int ReleaseMatrix(int[,] matrix)
{
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j)
        sum += matrix[i, j];
    }
  }
  return sum;
}
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine(ReleaseMatrix(matrix));