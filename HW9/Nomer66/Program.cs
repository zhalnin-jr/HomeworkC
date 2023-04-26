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
    Console.Write(Summ(N, M));

}
int Summ(int N, int M)
{
    if ((M != N + 1)) return Summ(N, M + 1) + M;
    else return 0;
}
start();