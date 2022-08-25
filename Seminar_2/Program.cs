/*

// Урок 2. Массивы и функции в программировании

//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit (int number) // void - т.е. не возвращает ничего. метод нужен только для дальнейшей работы.
{
    int dec = number % 100 / 10; // остаток деления на 100 - получаем десятки. далее целочисленное деление на 10 - получаем количество десятков, т.е. вторую цифру.
    return dec;
}

int randNumber = new Random().Next(100, 1000);
int secondDigit = FindSecondDigit(randNumber);

Console.WriteLine($"Second Digit in {randNumber} is {secondDigit}");



// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"В числе {number} ");

if (number < 0) number = number * (-1); // если ввели отрицательное число - сделаем его положительным

int count = 0; // счетчик цифр
int number_for_count = number; // создали переменную для счетчика
while (number_for_count > 0)
{
  count++;
  number_for_count = number_for_count/10;
}
Console.WriteLine($"цифр - {count}."); // посчитали цифры в числе

while (number > 999)
{
   number = number / 10; 
}

if (number < 100)
{
   Console.WriteLine($"Третьей цифры нет."); 
}
else
{
    number = number % 10;
    Console.WriteLine($"Третья цифра - {number}."); 
}


*/

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет