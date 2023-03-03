// Цикл for

for(int i = 0; i < 100; i++)
{
    if(i == 50)
    {
        break;
    }
    // Console.WriteLine($"{i} Hello world");
}


// Методы

int GetSum(int a, int b)
{
    int sum = a + b;
    return sum;
}

int sum = GetSum(10, 15);
Console.WriteLine(sum);