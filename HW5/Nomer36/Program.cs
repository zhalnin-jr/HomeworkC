int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result =int.Parse(num);
    return result;
}
int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
       array[i] = random.Next(-100,100);
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
int Summa(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i%2==1)
       {
        sum+=array[i];
       }
    }
    return sum;
}
Console.Clear();
int Length = Enter("Введите длину массива: ");
int[] array = GenerateArray(Length);
PrintArray(array);
Console.WriteLine($"(Сумма чисел стоящих под нечетным индексом: {Summa(array)})");