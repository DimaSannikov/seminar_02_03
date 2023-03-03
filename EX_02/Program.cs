// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Ведите номер четверти от 1 до 4: ");
int digit = int.Parse(Console.ReadLine());


void returnQuart(int chet)
{
    switch(chet)
    {
        case 1:
            Console.WriteLine("X > 0; Y > 0");
            break;
        
        case 2:
            Console.WriteLine("X < 0; Y > 0");
            break;
        
        case 3:
            Console.WriteLine("X < 0; Y < 0");
            break;
        
        case 4:
            Console.WriteLine("X > 0; Y < 0");
            break;
        
        default:
            Console.WriteLine("Такой четверти нет");
            break;
    }
}


returnQuart(digit);