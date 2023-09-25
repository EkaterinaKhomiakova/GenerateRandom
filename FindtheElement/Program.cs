// Задайте двумерный массив размера m x n
// каждый элемент в массиве находится по формуле Amn=m+n
// Выведите полученный массив на экран
// m = 3, n = 4
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = i + j;
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);