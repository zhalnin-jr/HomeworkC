// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
start();

void start()
{
    Console.Clear();
    int rows = Enter("m = ");
    int columns = Enter("n = ");
    Console.WriteLine();
    double[,] matrix =  GenerateArray(rows,columns );
    printMatrix(matrix);
}
int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result =int.Parse(num);
    return result;
}
double[,] GenerateArray(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            matrix[i,j] = Math.Round(rand.Next(10)*rand.NextDouble(),1);
       }
    }
    return matrix;
}
void printMatrix(double[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}


