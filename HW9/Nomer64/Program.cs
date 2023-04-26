int Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    int result = int.Parse(num);
    return result;
}
void start()
{
    Console.Clear();
    int N = Enter("до N = ");
    int M = Enter("от M = ");
    Console.WriteLine(NumberToLow(N, M));
}
string NumberToLow(int N, int M)
{
    if (M <= N) return NumberToLow(N, M + 1) + $"{M} ";
    else return string.Empty;
}
start();