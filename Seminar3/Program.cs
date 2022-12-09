// Задача №21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Coordinate(double xA, double yA, double xB, double yB, double zA, double zB)
{
    double dist = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)); 
    return dist;
}
Console.WriteLine("Введите координаты хА: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты хB: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты yА: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты zА: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(Coordinate(xA, xB, yA, yB, zA, zB), 4);
Console.WriteLine(distance);

*/

// Задача №23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Quandrant(int num)
{   
    int n = 1;
    while(n <= num)
    {
        Console.Write(Math.Pow(n,3) + " ");
        n++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Quandrant(num);

*/

// Задача №19: Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

bool Numbers(int zet)
{
    
}