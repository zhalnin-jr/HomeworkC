start();
void start()
{
    Console.Clear();
    int rows = Enter("1m = ");
    int columns = Enter("1n = ");
    int row = Enter("2m = ");
    int column = Enter("2n = ");
    Console.WriteLine();
    int[,] matrix = GenerateArray(rows, columns);
    int[,] matrix2 = GenerateArray(row, column);
    printMatrix(matrix);
    Console.WriteLine();
    printMatrix(matrix2);
    Console.WriteLine(" Полученная новая матрица ");
    printMatrix(Ex(matrix, matrix2));
}
int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result = int.Parse(num);
    return result;
}
int[,] GenerateArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
    return matrix;
}
void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] Ex(int[,] matrix, int[,] matrix2)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int num = 0; num < matrix.GetLength(1); num++)
            {
                result[i, j] += matrix[i, num] * matrix2[num, j];
            }
        }
    }
    return result;
}