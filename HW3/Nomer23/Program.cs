Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
double x;
for (int i = 1; i <= number; i++)
{
    x=Math.Pow(i,3);
    Console.Write($"{x} "); 
}