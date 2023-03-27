Console.Clear();
Console.Write("Введите 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    if (number1>number3)
    {
        Console.Write($"max 1 = {number1}");
    }
    else 
    {
        Console.Write($"max 3 = {number3}");
    }
}
else
{
    if (number2>number3)
    {
        Console.Write($"max 2 = {number2}");
    }
    else 
    {
         Console.Write($"max 3 = {number3}");
    }
} 