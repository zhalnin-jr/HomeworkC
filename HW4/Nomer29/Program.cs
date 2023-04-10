int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result =int.Parse(num);
    return result;
}
int[] GenerateArray(int Length, int MaxValue, int MinValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
       array[i] = random.Next(MinValue, MaxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Clear();
int Length = Enter("Введите длину массива: ");
int MinValue = Enter("Введите нижнюю границу чисел в массиве: ");
int MaxValue = Enter("Введите верхнюю границу чисел в массиве: ");
int[] array = GenerateArray(Length, MaxValue, MinValue);
PrintArray(array);