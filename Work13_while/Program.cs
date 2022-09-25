// Программа выводящая третью цифру слева, введенного в консоль, числа

// Метод ввода числа
int GetInputNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
// Метод вывода результата в консоль
void GetOutResult(int res)
{
    Console.WriteLine(res);
}
// Метод определения третьей цифры числа
int GetThreeNumber(int number)
{
    int outNumber = 0;
    while (number >= 100)
    {
        outNumber = number;
        number /= 10;
    }
    return outNumber%10;
}
// Начало программы
GetOutResult(GetThreeNumber(GetInputNumber()));
