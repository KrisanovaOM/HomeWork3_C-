//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Метод ввода числа
int GetInputNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

//Метод выводящий таблицу кубов
void GetCube(int number)
{
    int i = 1;
    Console.WriteLine("Таблица кубов до числа " + number + ":");
    while (i <= number)
    {
        Console.Write(Math.Pow(i,3) + ((i == number) ? "" : " "));
        i++;
    }
    Console.WriteLine();
}

GetCube(GetInputNumber());
