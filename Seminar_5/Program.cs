/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Вводные данные для формирования массива
Console.Write("Сколько элементов в массиве нужно? ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимально-возможное число в массиве (100): ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимально-возможное число в массиве (999): ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

// создаем массив из н-ного количества рандомных чисел указанного диапазона
void CreateRandomArray()
{
    int [] numbers = new int[quantity];
    int count = 0;  // создадим переменную для счетчика четных чисел в массиве
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minDigit, maxDigit + 1);
        Console.Write(Method (i) + ", ");
        if (numbers[i] % 2 == 0)  // увеличиваем счетчик если число четное
            count++; 
    }
    Console.Write("\b\b] -> " + count);  //  удаление двух последних символов и закрытие прямоугольной скобки

    int Method (int a)
    {
        return numbers[a];
    }
}

CreateRandomArray();
*/


/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Вводные данные для формирования массива
Console.Write("Сколько элементов в массиве нужно? ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимально-возможное число в массиве: ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимально-возможное число в массиве: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

// создаем массив из н-ного количества рандомных чисел указанного диапазона
void CreateRandomArray()
{
    int [] numbers = new int[quantity];
    int sum = 0;  // создадим переменную для счетчика чисел с НЕчетными индексами в массиве
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minDigit, maxDigit + 1);
        Console.Write(Method (i) + ", ");
        if (i % 2 != 0)  // если индекс НЕчетный
            sum += numbers[i]; 
    }
    Console.Write("\b\b] -> " + sum);  //  удаление двух последних символов и закрытие прямоугольной скобки

    int Method (int a)
    {
        return numbers[a];
    }
}

CreateRandomArray();
*/


/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Вводные данные для формирования массива
Console.Write("Сколько элементов в массиве нужно? ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимально-возможное число в массиве: ");
int minDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимально-возможное число в массиве: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

// создаем массив из н-ного количества рандомных чисел указанного диапазона
void CreateRandomArray()
{
    int [] numbers = new int[quantity];
    int DigitMin = maxDigit + 1;  // создадим переменную для начального минимального числа в массиве
    int DigitMax = 0;  // создадим переменную для начального минимального числа в массиве
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minDigit, maxDigit + 1);
        Console.Write(Method (i) + ", ");
        if (numbers[i] > DigitMax)  // если число больше максимального на данном цикле
            DigitMax = numbers[i];
        if (numbers[i] < (DigitMin))  // если число меньше минимального на данном цикле
            DigitMin = numbers[i];
    }
    int result = DigitMax - DigitMin;
    Console.WriteLine("\b\b] -> " + result);  //  удаление двух последних символов и закрытие прямоугольной скобки
    Console.WriteLine($"{DigitMax} - {DigitMin} = {result}");  // выводим результат

    int Method (int a)
    {
        return numbers[a];
    }
}

CreateRandomArray();
*/