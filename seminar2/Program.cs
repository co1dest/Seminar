/* int randNum = new Random().Next(10, 100);

int CutNum(int num)
{
    int cut1 = randNum / 10;
    int cut2 = randNum % 10;
    int max;
    if (cut1 > cut2)
    {
        max = cut1;
    }
    else
    {
        max = cut2;
    }
    return max;
}

int newnum = CutNum(randNum);

Console.WriteLine($"Hello, number {randNum} is {newnum}");
*/


/*

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Number(int n1, int n2)
{
    if(num1 % num2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool result = Number(num1, num2);
Console.WriteLine(result);

*/
/*
Console.WriteLine("Введите проверяемое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый делитель: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй делитель: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Concert(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool pig = Concert(num1, num2, num3);
Console.WriteLine(pig);
*/

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

// Задача