/*
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
if (numberB > numberA)
{
    Console.WriteLine($"max = {numberB}");
}
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.WriteLine($"max = {max}");
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}






