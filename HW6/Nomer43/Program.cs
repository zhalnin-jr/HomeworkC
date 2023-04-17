double Enter(string numb)
{
    Console.Write(numb);
    string num = Console.ReadLine();
    double result = double.Parse(num);
    return result;
}
void Start()
{
    Console.Clear();
    double b1 = Enter($"b1: ");
    double k1 = Enter($"k1: ");
    double b2 = Enter($"b2: ");
    double k2 = Enter($"k2: ");
    Console.WriteLine($"Координаты точки пересечения (x,y) - {searchPoint(b1,k1,b2,k2)}");
}
(double,double) searchPoint(double b1, double k1, double b2, double k2)
{
    double x=0;
    double y=0;
    x = (b2 - b1)/(k2 - k1);
    y = (b1*k2-b2*k1)/(k2-k1);
    return(x,y);
}
Start();
