﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

// Принял уточнение, что до N включительно

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
Console.Write($"Список четных чисел от 1 до {number}: ");
while (count <= number)
{
    if (count % 2 == 0) Console.Write($"{count}; ");
    count++;
}
