/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
01234
14212 -> нет
12821 -> да
23432 -> да*/

int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

char[] array = a.ToString().ToCharArray();

if (array[0]==array[4] && array[1]==array[3])
Console.Write("Это паллиндром!");
else Console.Write("Это не паллиндром!");



