// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// Можно вводить любое число с количеством знаков 2 и более
// Программа переводит число в строку, далее работа идет со строкой

Console.Write("Ведите число с количеством знаков два и более: ");
int digit = int.Parse(Console.ReadLine());

string isItPalindrome(int number)
{
    string strDigit = number.ToString();
    string result = "Введите число с количеством знаков 2 и более";

    if(strDigit.Length < 2)
    {
        result = result;
    }
    else
    {
        int countFirst = 0;
        int countLast = strDigit.Length - 1;
        int midList = strDigit.Length / 2;

        while(countFirst < countLast)
        {
            if(strDigit[countFirst] == strDigit[countLast])
            {
                midList -= 1;
            }
            countFirst += 1;
            countLast -= 1;
        }

        if(midList == 0)
        {
            result = $"Число {strDigit} является палиндромом";
        }
        else
        {
            result = $"Число {strDigit} не является палиндромом";
        }
    }

    return result;
}

string check = isItPalindrome(digit);
Console.WriteLine(check);

// Console.WriteLine(countLast);
// Console.WriteLine(midDigit);