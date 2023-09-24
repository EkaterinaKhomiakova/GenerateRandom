// Задайте двумерный массив размером mxn
// заполненный случайными целыми числами
// m=3, n=4,
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
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
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);