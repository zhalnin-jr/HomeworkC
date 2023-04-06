Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
if ((number[0]==number[4]) || (number[1]==number[3]))
{
    Console.Write($"Ваше число палиндром ={number}");
}
else
{
    Console.Write($"Ваше число НЕ палиндром ={number}");
}