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
    int number = Enter("Поиск данного числа в массиве: ");
    SearchNumber(matrix, number);
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

void SearchNumber(int[,] matrix, int number) //Костыль, но работает!
{
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (n == 0)
            {
                if (matrix[i, j] == number)
                {
                    Console.WriteLine($"Наше число {number} имеет первое нахождение на этих координатах ({j},{i})");
                    n++;
                }
            }
        }
    }
    if (n==0)
    {
        Console.WriteLine($"Наше число {number} не находится в массиве");
    }
}
