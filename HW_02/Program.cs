// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

Console.Write("Ведите X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Ведите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Ведите Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Ведите X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Ведите Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Ведите Z2: ");
int z2 = int.Parse(Console.ReadLine());


double get2D(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dist = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return dist;
}


double distance = Math.Round(get2D(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToEven);
Console.WriteLine(distance);