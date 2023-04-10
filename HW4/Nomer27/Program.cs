int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result =int.Parse(num);
    return result;
}
int sum(int number)
{
int result=0;
while (number > 0)
{
    result+=number%10;
    number/=10;
}
return result;
}
Console.Clear();
int number = Enter("Введите число: ");
Console.WriteLine($"Сумма всех цифр этого числа {number} равна этому {sum(number)}");