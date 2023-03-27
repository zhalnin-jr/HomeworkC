Console.Clear();
Console.WriteLine("Enter number 1 : ");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Enter number 2 : ");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);
if (num1 > num2 )
{
    Console.Write($"max = {num1}");
}
else 
{
    Console.Write($"max={num2}");
}