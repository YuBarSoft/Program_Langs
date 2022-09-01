// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// можно использовать метод Pow()
int result = Convert.ToInt32(Math.Pow(numberA, numberB));
Console.WriteLine($"{numberA}, {numberB} -> {result}");

// можно использовать умножение в цикле 
int result2 = 1;  // объявили переменную

for(int i=1; i <= numberB; i++) 
    result2 = result2 * numberA;

Console.WriteLine($"{numberA}, {numberB} -> {result2}");

// можно использовать умножение в цикле метода
int FindExponent(int numberA, int numberB)
{
    int result = 1;  // объявили переменную

    for(int i=1; i <= numberB; i++) 
        result = result * numberA;
    
    return result;
}

int exponent = FindExponent(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {exponent}");



/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.Write($"{number} -> "); // пишем первоначальное число после ввода

// нужно в цикле остатком от деления на 10 получить все цифры и сложить их
while (number > 0)
{
    int temp = number % 10;
    number = number / 10;
    sum = sum + temp;
}

Console.WriteLine(sum); // пишем сумму
*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




