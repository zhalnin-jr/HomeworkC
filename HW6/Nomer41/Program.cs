int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result = int.Parse(num);
    return result;
}
int[] inputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Enter($"Введите ({i + 1}) элемент: ");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int Count(int[ ] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}
Console.Clear();
int length = Enter("Enter the size of massive: ");
int[] array = inputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {Count(array)}");