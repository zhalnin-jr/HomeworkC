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
    int M = Enter("от m = ");
    int N = Enter("до n = ");
    Console.Write(Accerman(M, N));
}
int Accerman(int M, int N)
{
    if ((M == 0)) return N + 1;
    if (M > 0 && N == 0) return Accerman(M - 1, 1);
    return Accerman(M - 1, Accerman(M, N - 1));
}
start();