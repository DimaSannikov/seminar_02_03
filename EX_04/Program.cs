// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Console.Write("Ведите целое число: ");
// int digit = int.Parse(Console.ReadLine());

// for(int i = 1; i <= digit; i++)
// {
//     double sqr = Math.Pow(i, 2);
//     Console.WriteLine(sqr);
// }

Console.Write("Ведите целое число: ");
int digit = int.Parse(Console.ReadLine());


void getSqr(int num)
{
    for(int i = 1; i <= num; i++)
    {
        double sqr = Math.Pow(i, 2);
        Console.WriteLine(sqr);
    }
}


getSqr(digit);