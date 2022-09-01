/*
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt16(Console.ReadLine());

int FindExponent(int numberA, int numberB)
{
    // можно использовать метод Pow()
    // int result = Convert.ToInt32(Math.Pow(numberA, numberB));

    // и можно использовать умножение в цикле
    int result = 1;  // объявили переменную
    for(int i=1; i <= numberB; i++) 
        result = result * numberA;
    
    return result;
}

int exponent = FindExponent(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {exponent}");
*/


