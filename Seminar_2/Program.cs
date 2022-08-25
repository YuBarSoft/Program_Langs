// Урок 2. Массивы и функции в программировании

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit (int number) // void
{
    int dec = number % 100 / 10;
    return dec;
}

int randNumber = new Random().Next(100, 1000);
int secondDigit = FindSecondDigit(randNumber);

Console.WriteLine($"Second Digit in {randNumber} is {secondDigit}");