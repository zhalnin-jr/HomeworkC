﻿Console.Clear();
Console.WriteLine("Введите X1 для точки А");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y1 для точки А");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z1 для точки А");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X1 для точки B");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y2 для точки B");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z2 для точки B");
double Z2 = Convert.ToDouble(Console.ReadLine());
double AB;
AB=Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.Write($"Длина отрезка AB={AB}");