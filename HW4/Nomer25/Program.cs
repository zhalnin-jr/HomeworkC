int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result =int.Parse(num);
    return result;
}
int exp(int Base, int exponent)
{
    int main=1;
    for (int i = 0; i < exponent; i++)
    {
        main *= Base;
    }
    return main;
}
bool CheckExponent(int exponent)
{
    if (exponent<0)
    {
        Console.WriteLine("экспонента не должна быть меньше 0");
        return false;
    }
    return true;
}
Console.Clear();
int Base = Enter("Введите основание: ");
int exponent = Enter("Введите экспоненту: ");
if (CheckExponent(exponent))
{
    Console.WriteLine($"Если основание = {Base} и степень = {exponent}, то получим такое число = {exp(Base,exponent)}");
}