// Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Ведите целое число: ");
int digit = int.Parse(Console.ReadLine());


void getSqr(int num)
{
    for(int i = 1; i <= num; i++)
    {
        double sqr = Math.Pow(i, 3);
        Console.WriteLine(sqr);
    }
}


getSqr(digit);