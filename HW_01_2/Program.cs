// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

Console.Write("Ведите число с количеством знаков два и более: ");
int num = int.Parse(Console.ReadLine());

string isItPalindrome(int digit)
{
    List<int> digitsList = new List<int>();

    string result = "Введите число с количеством знаков 2 и более";

    int digitInList = digit;
    int digitsCount = digit;

    while(digitInList > 0 & digitsCount > 0)   // Цикл в котором каждая цифра числа добавляется в список
    {
        digitInList = digitsCount % 10;
        digitsCount = digitsCount / 10;
        
        digitsList.Add(digitInList);
    }

    if(digitsList.Count < 2)                     // Проверяем чтобы число было с двумя и более знаками
    {
        result = result;
    }
    else
    {
        int countFirst = 0;                      // Первый элемент списка
        int countLast = digitsList.Count - 1;    // Последний элемент списка
        int midList = digitsList.Count / 2;      // Середина списка

        while(countFirst < countLast)            // Цикл в котором сравниваются элементы списка
        {
            if(digitsList[countFirst] == digitsList[countLast])
            {
                midList -= 1;
            }
            countFirst += 1;
            countLast -= 1;
        }

        if(midList == 0)
        {
            result = $"Число {digit} является палиндромом";
        }
        else
        {
            result = $"Число {digit} не является палиндромом";
        }
    }
    return result;
}

string check = isItPalindrome(num);
Console.WriteLine(check);