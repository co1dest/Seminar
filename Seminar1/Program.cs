 // Семинар 1. Знакомство

 // Задача №1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
int max = num1;
 
if (max > num2)
{
   Console.Write(max);
}
else
{
   max = num2;
   Console.Write(max);
}
*/
 
 // Задача №2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*

 Console.Write("Input fest number: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input second number: ");
 int num2 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input third number: ");
 int num3 = Convert.ToInt32(Console.ReadLine());

 int max = num1;

if(max > num2)
{

}
else
{
    max = num2;
}
if(max > num3)
{
    
}
else
{
    max = num3;
}
Console.Write(max);

*/

// Задача №3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = n % 2;

if(a != 0)
{
    Console.Write("No");
}
else
{
    Console.Write("Yes");
}

*/

//Задача №4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;
int size = 2;

while(current <= n)
{
    if(size <= n)
    {
        Console.Write(size + " ");
        size += 2;
    }
    else
    {

    }
    current++;
}

*/