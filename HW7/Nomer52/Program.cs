﻿start();
void start()
{
    Console.Clear();
    int rows = Enter("m = ");
    int columns = Enter("n = ");
    Console.WriteLine();
    int[,] matrix = GenerateArray(rows, columns);
    printMatrix(matrix);
    Console.WriteLine();
    SumColumns(matrix);
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
void SumColumns(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum =(sum + matrix[i,j]);
        }
        Console.Write($"{Math.Round(sum/matrix.GetLength(0),1)}   ");
        sum = 0;
    }
}