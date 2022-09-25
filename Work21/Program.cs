//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

//Метод ввода координат
double GetCoordinat(string coordinate)
{
    Console.WriteLine("Введите координату " + coordinate);
    return Convert.ToDouble(Console.ReadLine());
}

//Метод определения расстояния между двумя точками в 3D 
double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return  Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
}

//начало программы
double x1 = GetCoordinat("x1");
double y1 = GetCoordinat("y1");
double z1 = GetCoordinat("z1");
double x2 = GetCoordinat("x2");
double y2 = GetCoordinat("y2");
double z2 = GetCoordinat("z2");


Console.WriteLine("Расстояние между точками: " + Distance3D(x1, y1, z1, x2, y2, z2));
