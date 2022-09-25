//Напишите программу, которая по заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

// Метод ввода числа
int GetInputNumber()
{
    Console.WriteLine("Введите номер четверти: ");
    return Convert.ToInt32(Console.ReadLine());
}

//Метод, возвращающий строку описания
void GetWriteLine(string x, string y)
{
   Console.WriteLine("Диапазон возможных координат: " + x + ", " +  y); 
}

//Метод, определяющий диапазон возможных координат x и y
void Range(int number)
{
    if (number == 1) GetWriteLine("x > 0", "y > 0");
    if (number == 2) GetWriteLine("x < 0", "y > 0");
    if (number == 3) GetWriteLine("x < 0", "y < 0");
    if (number == 4) GetWriteLine("x > 0", "y < 0");
}

Range(GetInputNumber());