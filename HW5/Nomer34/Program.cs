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
       array[i] = random.Next(100, 1000);
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
int count(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]%2==0)
       {
        count+=1;
       }
    }
    return count;
}
Console.Clear();
int Length = Enter("Введите длину массива: ");
int[] array = GenerateArray(Length);
PrintArray(array);
Console.WriteLine($"(Кол-во четных чисел: {count(array)})");