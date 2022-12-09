// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int Number(int numb)
{
    int sum = 0;
    
    for(int current = 1; current <= 0; current++)
    {
        sum = sum + current;
    }
    return sum;

}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = Number(num);
Console.WriteLine($"Сумма числел числа {num} равен {result}");

*/








// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Num(int n)
{
    int count = 0;

    while(n > 0)
    {
        n = n / 10; 
        count++;

    }
    return count;
}

Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Num(n);
Console.WriteLine(result);


*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int Factorial(int num)
{
    int factor = 1;
    for(int cout = 1; cout <= num; cout++)
    {
        factor = cout * factor;
    }
    return factor;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);
Console.WriteLine(result);

*/
/*

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

Console.WriteLine("Введите количество элементов: ");
int leght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(leght, min, max);
ShowArray(myArray);

*/


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