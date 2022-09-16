/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int m = 3; // количество строк в создаваемом массиве
int n = 4; // количество столбцов в создаваемом массиве

Console.WriteLine($"Создан массив из {m} строк и {n} столбцов со случайными целыми числами:");
int[,] newArray = new int[m, n];

void CreateRandom2dArray(int[,] array) // забиваем массив рандомными числами от -100 до 100
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = Convert.ToInt32(new Random().Next(-100, 100 + 1));
}

void Show2dArray(int[,] array) // выводим массив
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();        
    }
    
    Console.WriteLine();   
}

void SortDescending(int[,] array) // сортируем по убыванию
{
    Console.WriteLine("Пересортировываем массив по убыванию элементов каждой строки:");
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			for (int k = 0; k < array.GetLength(1) - 1; k++)
				if (array[i, k] < array[i, k + 1])
				{
					int temp = array[i, k + 1];
					array[i, k + 1] = array[i, k];
					array[i, k] = temp;
				}
}

CreateRandom2dArray(newArray);
Show2dArray(newArray);

SortDescending(newArray);
Show2dArray(newArray);
*/



/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int m = 3; // количество строк в создаваемом массиве
int n = 4; // количество столбцов в создаваемом массиве

Console.WriteLine($"Создан массив из {m} строк и {n} столбцов со случайными целыми числами:");
int[,] newArray = new int[m, n];

void CreateRandom2dArray(int[,] array) // забиваем массив рандомными числами от -100 до 100
{
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			newArray[i, j] = Convert.ToInt32(new Random().Next(-100, 100 + 1));
}

void Show2dArray(int[,] array) // выводим массив
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();        
    }
    
    Console.WriteLine();   
}

void SumNumbers(int[,] array) // суммируем элементы в строках, находим индекс строки с минимальным значением
{
    int minData = 401; // для случая, если вдруг все числа в строке будут равны 100
    int indexLine = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];        
            Console.WriteLine($"Cумма элементов {i+1} строки = {sum}");
        
        if (sum < minData)
        {
            minData = sum;
            indexLine = i+1;
        }
    }

    Console.WriteLine($"\nСтрока с наименьшей суммой элементов ({minData}): {indexLine}\n");
}

CreateRandom2dArray(newArray);
Show2dArray(newArray);
SumNumbers(newArray);
*/



/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2  4 | 3  4
// 3  2 | 3  3
// Результирующая матрица будет:
// 18  20
// 15  18
// Решаем:
// 1*3 + 4*3  2*4 + 4*3
// 3*3 + 2*3  3*4 + 2*3
// Результат:
// 18  20
// 15  18

// Формула умножения двух квадратных матриц 2х2
// | a1   b1 |   | c1   d1 |   | a1*c1+b1*c2   a1*d1+b1*d2 |
// |         | * |         | = |                           |
// | a2   b2 |   | c2   d2 |   | a2*c1+b2*c2   a2*d1+b2*d2 |
//
// Чтобы матрицу можно было умножить на матрицу нужно,
// чтобы число столбцов первой матрицы равнялось числу строк второй матрицы.
//
// Будем умножать квадратные матрицы типа 2х2...

Console.Clear();

Console.Write("Укажите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Выделили память
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixC = new int[size, size]; 

// Создание массива случайных чисел
void MakeRandNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-4, 5); // установили диапазон чисел в матрицах от 1 до 4 включительно
}

// Создание матрицы произведения
void MultiplicationMatrix(int[,] array)
{
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
           for (int k = 0; k < size; k++)
               matrixC[i, j] += (matrixA[i, k] * matrixB[k, j]);
}

// Вывод матриц на печать
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

MakeRandNumbersArray(matrixA);
MakeRandNumbersArray(matrixB);
MultiplicationMatrix(matrixC);

Console.WriteLine("Матрица А:");
PrintArray(matrixA);
Console.WriteLine();

Console.WriteLine("Матрица В:");
PrintArray(matrixB);
Console.WriteLine();

Console.WriteLine("Произведение матриц А*В:");
PrintArray(matrixC);
Console.WriteLine();
*/



/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

// Создаем матрицу с запрашиваемыми параметрами
int[,,] CreateMatrix(int x, int y, int z, int min, int max)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k);
    return matrix;
}

// Уникальность элементов матрицы
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool hereBreak = false;
        value = new Random().Next(min, max);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (hereBreak) {break;}
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (hereBreak) {break;}
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) {hereBreak = true; break;}   
                    if (i1 == i && j1 == j && k1 == k) {exist = false;}
                }
            }
        }
    }
    return value;
}

// Вывод матрицы на печать
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k}) ");
            Console.WriteLine();
        }
}

// The End
int[,,] array3D = CreateMatrix(2, 2, 2, 10, 100); // задаем параметры матрицы 2х2х2 с элементами от 10 до 99
PrintMatrix(array3D);
Console.WriteLine();
*/



/*
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;

    if (i <= j+1 && i+j < size-1)
        j++;
    else if (i < j && i+j >= size-1)
        i++;
    else if (i >= j && i+j > size-1)
        j--;
    else
        i--;

    num++;
}

// Вывод массива на печать
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) {Console.Write("0");} // если число меньше 10, то добавим 0 перед ним
            Console.Write(array[i, j] + "  ");
        }

        Console.WriteLine();        
    }
}

// The End
PrintArray(nums);
Console.WriteLine();
*/