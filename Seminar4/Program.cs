// Задача №25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int Numb(int a, int b)
{
    int step = 1;
    for(int st = 1; st <= b; st++)
    {
        step = step * a;
    }
    return step;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Numb(a, b);

Console.WriteLine(result);

*/

//Задача №27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Massif(int n)
{
    int x = 1;
    int sum = 0;
    while(n > 0)
    {
        x = n % 10;
        sum = sum + x;
        n = n / 10;
    }
    return sum;
}
int result = Massif(n);
Console.WriteLine(result);

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }   
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateArray(size);
ShowArray(myArray);

*/