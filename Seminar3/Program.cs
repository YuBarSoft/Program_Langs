Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int num = 0;
int ost = 0;
int all = 0;
int temp = 0;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

temp = num; // кидаем первоначальное число во временную переменную temp

while (Convert.ToBoolean(num))
{
    ost = num % 10; // получаем остаток от деления на 10
    num = num / 10; // получаем результат целочисленного деления на 10
    all = all * 10 + ost; // умножаем сумму на 10 и добавляем остаток
}
Console.WriteLine($"-В обратном порядке: {all}");
if (temp == all) // сравнение введенного числа и перевернутого
{
    Console.WriteLine($"Число {all} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {all} не является палиндромом.");
}
