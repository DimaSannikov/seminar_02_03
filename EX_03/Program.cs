// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Ведите X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Ведите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Ведите X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Ведите Y2: ");
int y2 = int.Parse(Console.ReadLine());


double get2D(int xa, int ya, int xb, int yb)
{
    double dist = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
    return dist;
}


double distance = Math.Round(get2D(x1, y1, x2, y2), 3, MidpointRounding.ToEven);
Console.WriteLine(distance);