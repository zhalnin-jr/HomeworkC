int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result = int.Parse(num);
    return result;
}
double[] GenerateArray(int Length)
{
    double[] array = new double[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {

        array[i] = Math.Round(Convert.ToDouble(random.Next(0,100)*random.NextDouble()),3);
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double Raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i = i + 1;
    }
    return max - min;
}
Console.Clear();
int Length = Enter("Введите длину массива: ");
double[] array = GenerateArray(Length);
PrintArray(array);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {Raznica(array)}");