//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
//палиндромом.

// Метод ввода числа
int GetInputNumber()
{
    Console.WriteLine("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

//метод проверки числа на пятизначность
bool IsFiveNumber(int inputNumber)
{
    for (int i = 1; i < 5; i++)
    {
        inputNumber /= 10;
    }
    if (inputNumber > 0 && inputNumber < 10)
    {
        return true;
    }
    else 
    {
        return false;
    }
}


//Метод проверки является ли число палиндромом
bool IsPalindrom(int inputNumber)
{
    int oneDigit = inputNumber / 10000;
    int twoDigit = (inputNumber / 1000)%10;
    int fourDigit = (inputNumber / 10)%10;
    int fiveDigit = inputNumber%10;
    if (oneDigit == fiveDigit && twoDigit == fourDigit)
    {
        return true;
    }
        
    return false;
    
}
//начало программы
int inputNumber = GetInputNumber();

if (IsFiveNumber(inputNumber))
{
    if (IsPalindrom(inputNumber))
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число");
}