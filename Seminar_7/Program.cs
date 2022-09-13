/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] newArray = new double[m, n];

void CreateRandom2dArray(double[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100 + 1)) / 10;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();        
    }
    
    Console.WriteLine();   
}

CreateRandom2dArray(newArray);
Show2dArray(newArray);
*/



/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int m = 3; // количество строк в создаваемом массиве
int n = 4; // количество столбцов в создаваемом массиве

Console.WriteLine($"Для получения числа в ячейке таблицы из {m} строк и {n} столбцов введите ниже ее координаты.");
int[,] newArray = new int[m, n];

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = Convert.ToInt32(new Random().Next(-100, 100 + 1));
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();        
    }
    
    Console.WriteLine();   
}

CreateRandom2dArray(newArray);
Show2dArray(newArray);

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

void CheckArray()
{
    if (row > newArray.GetLength(0) || column > newArray.GetLength(1))
        Console.WriteLine("Такой ячейки в таблице нет.");

    else
        Console.WriteLine($"Значение числа в ячейке {row} строки и {column} столбца равно {newArray[row - 1, column - 1]}");
}

CheckArray();
*/



/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3; // количество строк в создаваемом массиве
int n = 4; // количество столбцов в создаваемом массиве

Console.WriteLine($"Дан массив из {m} строк и {n} столбцов со случайными целыми числами:");
int[,] newArray = new int[m, n];

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = Convert.ToInt32(new Random().Next(-100, 100 + 1));
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();        
    }
    
    Console.WriteLine();   
}

CreateRandom2dArray(newArray);
Show2dArray(newArray);

void Average()
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double avrg = 0; // объявили переменную для подсчета суммы в столбце
        for (int i = 0; i < newArray.GetLength(0); i++)
            avrg = (avrg + newArray[i, j]);

        avrg = avrg / m; // делим на количество строк
        avrg = Math.Round(avrg, 2); // округляем до указанного числа десятичных разрядов после запятой
        Console.Write(avrg + "\t");
    }
}

Average();
*/
