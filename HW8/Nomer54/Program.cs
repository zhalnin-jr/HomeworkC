start();
void start()
{
    Console.Clear();
    int rows = Enter("m = ");
    int columns = Enter("n = ");
    Console.WriteLine();
    int[,] matrix = GenerateArray(rows, columns);
    printMatrix(matrix);
    Console.WriteLine();
    Sorting(matrix);
    printMatrix(matrix);
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
            matrix[i, j] = rand.Next(10);
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
int[,] Sorting(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i,j]<matrix[i,j+1])
                {
                    int a=matrix[i,j];
                    matrix[i,j]=matrix[i,j+1];
                    matrix[i,j+1] = a;
                }
            }
        }
    }
    return matrix;
}