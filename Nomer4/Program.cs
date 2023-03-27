Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number!=1)
{
    if (number%2==0)
    {
        Console.WriteLine(number);
        number=number-1;
    }
    else
    {
        
        number=number-1;
    }
}