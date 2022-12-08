// Задача №13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

Console.WriteLine("Введите число: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
int numbers = Numbers(nam1);
Console.WriteLine(numbers);


int Numbers(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

*/

// Задача №10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int Number(int num)
{
    int second = num1 % 100;
    int one = second / 10;
    
    
    return one;
}


int result = Number(num1);
Console.WriteLine(result);

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

Console.WriteLine("Введите цифру обозначающую день недели: ");
int numbers = Convert.ToInt32(Console.ReadLine());

bool Day(int num)
{
    if(numbers < 6)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool result = Day(numbers);
Console.WriteLine(result);

*/